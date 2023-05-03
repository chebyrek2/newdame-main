using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class bomb : MonoBehaviour
{
    public GameObject Player;
    public int Damage;
    public NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.destination = Player.transform.position;
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);


        }
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<hp>().GetDamage(Damage);
        }

    }
}
