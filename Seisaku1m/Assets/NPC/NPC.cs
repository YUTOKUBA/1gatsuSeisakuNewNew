﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class NPC : MonoBehaviour
{
    public Transform[] points;
    NavMeshAgent agent;
    Animator animator;

    int n = 0;
    int count = 0;
    int R;
    bool flgA;
    bool flgB;
    bool flgC;
    static bool GameOver = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        //agent.destination = points[0].position;
    }

    void Update()
    {
        flgA = ScoreManager.flagA();
        flgB = ScoreManager.flagB();
        flgC = ScoreManager.flagC();
        animator.SetFloat("speed", agent.velocity.magnitude);
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            if (n == 1)
            {
                n = 0;
            }
            else
            {
                n = 1;
            }
            if (n == 1 && count != 0)
            {
                agent.speed = 0f;
                animator.SetInteger("param1", 1);
                agent.updateRotation = false;
                if (flgA == false && flgB == false && flgC == false)
                {

                }
                else
                {
                    GameOver = true;
                }
            }
            if (n == 1 && count == 0)
            {
                count++;
            }
            if (n == 0)
            {
                agent.speed = 0f;
                StartCoroutine(StopCoroutine());
            }

            agent.destination = points[n].position;
        }

        if (animator.GetAnimatorTransitionInfo(0).IsName("check -> walk"))
        {
            animator.SetInteger("param1", 0);
            agent.updateRotation = true;
            agent.speed = 1.2f;
        }
    }
    private IEnumerator StopCoroutine()
    {
        R = Random.Range(8, 23);
        yield return new WaitForSeconds(R);
        agent.speed = 1.2f;
    }
    public static bool gameover()
    {
        return GameOver;
    }
}

