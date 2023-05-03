using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class lazer : MonoBehaviour
{
    public GameObject Player;
    public int Damage;
    public NavMeshAgent agent;
    public GameObject Gate;

    public void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        var anim = collision.gameObject.GetComponent<hp>();
        if (anim != null)
        {
            anim.GetDamage(35);
        }
    }
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void OnDestroy()
    {
        Destroy(Gate);
    }
    private void Update()
    {
        agent.destination = Player.transform.position;
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "sword")
        {
            Destroy(this.gameObject);


        }
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<hp>().GetDamage(Damage);
        }


    }
}


