using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class NPC : MonoBehaviour
{
    //public Transform[] points;
    //private int point = 0;
    //[SerializeField] private Animator animator;
    //private NavMeshAgent agent;

    //void Start()
    //{
    //    agent = GetComponent<NavMeshAgent>();

    //    agent.autoBraking = false;
    //    GotoNextPoint();
    //}
    //void GotoNextPoint()
    //{
    //    if(points.Length == 0)
    //    {
    //        return;
    //    }
    //    agent.destination = points[point].position;
    //    point = (point + 1) % points.Length;
    //}
    //void Update()
    //{   
    //    animator.SetFloat("speed", agent.velocity.magnitude);
    //    if (!agent.pathPending && agent.remainingDistance < 0.5f)
    //    {

    //            GotoNextPoint();
    //    }
    //}

    public Transform[] points;
    //public Transform point;
    NavMeshAgent agent;
    Animator animator;

    int n = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        agent.destination = points[0].position;
    }

    void Update()
    {
        animator.SetFloat("speed", agent.velocity.magnitude);
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            if(n == 1)
            {
                n = 0;
            }
            else
            {
                n = 1;
            }
            if(n == 1)
            {
                agent.speed = 0f;
                animator.SetInteger("param1", 1);
                agent.updateRotation = false;
            }
            agent.destination = points[n].position;
        }
        if(animator.GetAnimatorTransitionInfo(0).IsName("check -> walk"))
        {
            animator.SetInteger("param1", 0);
            agent.updateRotation = true;
            agent.speed = 1.2f;
        }
    }
}
