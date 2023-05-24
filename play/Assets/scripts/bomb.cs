using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class bomb : MonoBehaviour
{
    public GameObject Player;
    public int Damage;
    
    
    
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<hp>().GetDamage(Damage);
        }

    }
}
