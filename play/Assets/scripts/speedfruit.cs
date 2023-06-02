using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedfruit : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);


        }
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<player>().SpeedPlus();
        }


    }
}
