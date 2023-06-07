using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lessongate : MonoBehaviour
{
    
    public int Damage;
    
    



    
    
    
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
