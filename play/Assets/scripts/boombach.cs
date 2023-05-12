﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class boombach : MonoBehaviour
{
    private hp _HP;
    private Animator Animator;
    public int Damage = 40;
    public GameObject Player;
    public NavMeshAgent agent;
    public GameObject Portal;
    public float Distant = 10;
    private bool Dead = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Portal.SetActive(false);
        Animator = GetComponent<Animator>();
        Animator.Play("mon00_walk");
    }

    void Update()
    {
        if (!Dead)
            agent.destination = Player.transform.position;
        if (Vector3.Distance(transform.position, Player.transform.position) <= Distant)
        {
            if (!Dead)
            {
                
                if (Animator.GetBool("end anim"))
                {
                    Player.GetComponent<hp>().GetDamage(Damage);
                    Animator.SetBool("end anim", false);
                }
            }
        }
        else
        {
            if (!Dead)
                Animator.Play("mon00_walk");
        }
    }
    

    public void Death()
    {
        agent.destination = transform.position;
        Animator.Play("mon00_attack01");
        Portal.SetActive(true);
        Dead = true;
    }
}