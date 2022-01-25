using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum EnemyStates { GUARD, PATROL, CHASE, DEAD }

[RequireComponent(typeof(NavMeshAgent))] // ȷ����ק���������ϴ˱������һ������
public class EnemyController : MonoBehaviour
{
    private NavMeshAgent agent;
    private EnemyStates enemyStates;
    private Animator anim;

    [Header("Basic Settings")]
    public float sightRadius;
    public bool isGuard;
    private float speed;
    private GameObject attackTarget;
    public float lookAtTime;
    private float remainLookAtTime;

    [Header("Patrol State")]
    public float patrolRange;
    private Vector3 wayPoint;
    private Vector3 guardPos;
    // bool��϶���
    bool isWalk;
    bool isChase;
    bool isFollow;

	private void Awake()
	{
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        speed = agent.speed;
        guardPos = transform.position;
        remainLookAtTime = lookAtTime;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (isGuard)
        {
            enemyStates = EnemyStates.GUARD;
        }
        else
        {
            enemyStates = EnemyStates.PATROL;
            GetNewWayPoint();
        }
    }

    // Update is called once per frame
    void Update()
    {
        SwitchStates();
        SwitchAnimation();
    }

    void SwitchStates()
	{
        if (FoundPlayer())
		{
            enemyStates = EnemyStates.CHASE;
            Debug.Log("Found Player");
		}
        switch (enemyStates)
		{
            case EnemyStates.GUARD:
                break;
            case EnemyStates.PATROL:
                isChase = false;
                agent.speed = speed * 0.5f;

                // �ж��Ƿ������Ѳ�ߵ�
                if(Vector3.Distance(wayPoint, transform.position) <= agent.stoppingDistance)
				{
                    isWalk = false;
                    //��һ��
                    if (remainLookAtTime > 0)
                        remainLookAtTime -= Time.deltaTime;
                    GetNewWayPoint();
				}
                else
				{
                    isWalk = true;
                    agent.destination = wayPoint;
				}

                break;
            case EnemyStates.CHASE:
                // ׷player
                // �ڹ�����Χ���򹥻�
                // ��϶���
                isWalk = false;
                isChase = true;

                agent.speed = speed;
				
                if (!FoundPlayer())
				{
                    // ���ѻص��ϸ�״̬
                    isFollow = false;
                    if (remainLookAtTime > 0)
                    {
                        remainLookAtTime -= Time.deltaTime;
                    }
                    else if (isGuard)
                        enemyStates = EnemyStates.GUARD;
                    else
                        enemyStates = EnemyStates.PATROL;
                    
                }
				else
				{
                    isFollow = true;
                    agent.destination = attackTarget.transform.position;
				}
                break;
            case EnemyStates.DEAD:
                break;

		}
	}

    bool FoundPlayer()
	{
        var colliders = Physics.OverlapSphere(transform.position, sightRadius);

        foreach (var target in colliders)
		{
            if (target.CompareTag("Player"))
			{
                attackTarget = target.gameObject;
                return true;
			}
		}

        attackTarget = null;
        return false;
	}

    void SwitchAnimation()
	{
        anim.SetBool("Walk", isWalk);
        anim.SetBool("Chase", isChase);
        anim.SetBool("Follow", isFollow);
	}



    void GetNewWayPoint()
	{
        remainLookAtTime = lookAtTime;
        float randomX = Random.Range(-patrolRange, patrolRange);
        float randomZ = Random.Range(-patrolRange, patrolRange);

        Vector3 randomPoint = new Vector3(guardPos.x + randomX, transform.position.y, guardPos.z + randomZ);
        // ��ֹ�ƶ���unwalkable����
        NavMeshHit hit;
        wayPoint = NavMesh.SamplePosition(randomPoint, out hit, patrolRange, 1) ? hit.position : transform.position;
    }

	private void OnDrawGizmosSelected()
	{
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, sightRadius);
	}
}
