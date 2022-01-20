using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class NPC : MonoBehaviour
{
    public Transform point;
    [SerializeField] private Animator animator;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = point.position;
    }
    void Update()
    {
        animator.SetFloat("speed", agent.velocity.magnitude);
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            animator.SetFloat("speed", -1);
        }
    }
}
