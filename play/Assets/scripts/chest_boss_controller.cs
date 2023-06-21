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
    private bool Dead = false;
    public GameObject EmptyHP;
    public GameObject ParticleS;
    public Vector3 Smesh;
    public GameObject RotationPS;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Portal.SetActive(false);
        Animator = GetComponent<Animator>();
        Animator.Play("WalkFWD");
    }

    void Update()
    {
        if (!Dead)
            agent.destination = Player.transform.position;
        if (Vector3.Distance(transform.position, Player.transform.position) <= Distant)
        {
            if (!Dead)
            {
                Animator.Play("Attack01");
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
                Animator.Play("WalkFWD");
        }
    }
    public void GetDamage()
    {
        Animator.Play("GetHit");
    }

    public void Death()
    {
        agent.destination = transform.position;
        Animator.Play("Die");
        var instance = Instantiate(ParticleS, Portal.transform.position + Smesh, RotationPS.transform.rotation);
        Portal.SetActive(true);
        Dead = true;
        Destroy(EmptyHP);
    }
}
