using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator anim;
    private GameObject attackTarget;
    private float lastAttackTime;

	private void Awake()
	{
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
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
        SwitchAnimation();
        lastAttackTime -= Time.deltaTime;
    }

    private void SwitchAnimation()
	{
        anim.SetFloat("Speed", agent.velocity.sqrMagnitude); // ��Vector3��ֵת��Ϊ����
        
	}

    private void EventAttack(GameObject target)
    {
        if (target != null)
        {
            attackTarget = target;
            StartCoroutine(MoveToAttackTarget());
        }
    }

    IEnumerator MoveToAttackTarget()
	{
        agent.isStopped = false; 

        transform.LookAt(attackTarget.transform);

        while (Vector3.Distance(attackTarget.transform.position, transform.position) > 1)
		{
            agent.destination = attackTarget.transform.position;
            yield return null;
		}

        agent.isStopped = true;
		// Attack

		if (lastAttackTime < 0)
		{
            anim.SetTrigger("Attack");
            // ������ȴʱ��
            lastAttackTime = 0.5f;
		}
	}

    public void MoveToTarget(Vector3 target)
    {
        StopAllCoroutines(); // ��Ϲ�������
        agent.isStopped = false;
        agent.destination = target;
    }
}
