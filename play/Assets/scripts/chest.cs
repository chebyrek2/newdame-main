using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    public GameObject player;
    public float speed;


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "sword")
        {
            Destroy(this.gameObject);


        }
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<hp>().GetDamage(29);
        }

    }
}
