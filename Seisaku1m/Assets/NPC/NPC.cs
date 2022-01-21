using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class NPC : MonoBehaviour
{
    public Transform[] points;
    private int point = 0;
    [SerializeField] private Animator animator;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = false;
        GotoNextPoint();
    }
    void GotoNextPoint()
    {
        if(points.Length == 0)
        {
            return;
        }
        agent.destination = points[point].position;
        point = (point + 1) % points.Length;
    }
    void Update()
    {   
        animator.SetFloat("speed", agent.velocity.magnitude);
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
           
                GotoNextPoint();
        }
    }
}
