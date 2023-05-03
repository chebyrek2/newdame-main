using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chest_boss_controller : MonoBehaviour
{
    private hp _HP;
    private Animator Animator;
    public int Damage = 40;
    public GameObject Player;
    public NavMeshAgent agent;
    public GameObject Portal;
    public float Distant = 10;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Portal.SetActive(false);
        Animator = GetComponent<Animator>();
        Animator.Play("WalkFWD");
    }

    void Update()
    {
        agent.destination = Player.transform.position;
        if (Vector3.Distance(transform.position, Player.transform.position) <= Distant)
        {
            Animator.Play("Attack01");
            if (Animator.GetBool("end anim"))
            {
                Player.GetComponent<hp>().GetDamage(Damage);
                Animator.SetBool("end anim", false);
            }
        }
        else
        {
            Animator.Play("WalkFWD");
        }
    }
    private void OnDestroy()
    {
        Portal.SetActive(true);
    }
    public void GetDamage()
    {
        Animator.Play("GetHit");
    }

    public void Death()
    {
        Animator.Play("Die");
    }
}
