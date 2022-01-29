using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator anim;
    private CharacterStats characterStats;

    private GameObject attackTarget;
    private float lastAttackTime;

    private bool isDead;

	private void Awake()
	{
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        characterStats = GetComponent<CharacterStats>();
	}
	// Start is called before the first frame update
	void Start()
    {
        MouseManager.Instance.OnMouseClicked += MoveToTarget; // ע��action������
        MouseManager.Instance.OnEnemyClicked += EventAttack;
    }


    // Update is called once per frame
    void Update()
    {
        isDead = characterStats.CurrentHealth == 0; //���д��
        SwitchAnimation();
        lastAttackTime -= Time.deltaTime;
    }

    private void SwitchAnimation()
	{
        anim.SetFloat("Speed", agent.velocity.sqrMagnitude); // ��Vector3��ֵת��Ϊ����
        anim.SetBool("Death", isDead);
        
	}

    private void EventAttack(GameObject target)
    {
        if (target != null)
        {
            attackTarget = target;
            characterStats.isCritical = UnityEngine.Random.value < characterStats.attackData.criticalChance;
            StartCoroutine(MoveToAttackTarget());
        }
    }

    IEnumerator MoveToAttackTarget()
	{
        agent.isStopped = false; 

        transform.LookAt(attackTarget.transform);

        while (Vector3.Distance(attackTarget.transform.position, transform.position) > characterStats.attackData.attackRange)
		{
            agent.destination = attackTarget.transform.position;
            yield return null;
		}

        agent.isStopped = true;
		// Attack

		if (lastAttackTime < 0)
		{
            anim.SetTrigger("Attack");
            anim.SetBool("Critical", characterStats.isCritical);
            // ������ȴʱ��
            lastAttackTime = characterStats.attackData.coolDown;
		}
	}

    public void MoveToTarget(Vector3 target)
    {
        StopAllCoroutines(); // ��Ϲ�������
        agent.isStopped = false;
        agent.destination = target;
    }

    // Animation Event
    void Hit()
	{
        var targetStats = attackTarget.GetComponent<CharacterStats>();

        targetStats.TakeDamage(characterStats, targetStats);
	}
}
