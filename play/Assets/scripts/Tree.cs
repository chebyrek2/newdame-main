using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject Heal;
    public List<GameObject> Spawners;
    private hp HP;
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

    public void DropHeal()
    {
        Instantiate(Heal, Spawners[Random.Range(0, Spawners.Count)].transform.position, Heal.transform.rotation);

    }
    
}
