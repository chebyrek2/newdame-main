using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pula : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody rb;
    public int Damage;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
            rb.velocity = transform.forward * speed;
    }

    public void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        var anim = collision.gameObject.GetComponent<hp>();
        if (anim != null) 
        {
            anim.GetDamage(Damage);
        }
    }
    
    

}
