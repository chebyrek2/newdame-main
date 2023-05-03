using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vzriv : MonoBehaviour
{
    public float explosionRadius = 5;
    public float power = 500;
    private Rigidbody[] physicObject;

    private Rigidbody[] physicobject; 
    void Start()

    {
        physicObject = FindObjectsOfType(typeof(Rigidbody)) as Rigidbody[];
        for (int i = 0; i < physicObject.Length; i++)
        {
            if (Vector3.Distance(transform.position, physicObject[i].transform.position) <= explosionRadius)
            {
                physicObject[i].AddExplosionForce(power, transform.position, explosionRadius);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
