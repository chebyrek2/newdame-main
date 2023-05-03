using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redzombie : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public ParticleSystem explosion;
    public ParticleSystem PS;              //Particle system

    private void Start()
    {
        PS = Instantiate(explosion, this.gameObject.transform);
    }

    private void Update()
    {
        PS.transform.position = this.gameObject.transform.position;
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "sword")
        {
            Destroy(this.gameObject);


        }
        if (other.gameObject.tag == "aboba")
        {
            PS.Play();
            Destroy(gameObject);
            Destroy(other.gameObject);
            
            
        }
    }
}
