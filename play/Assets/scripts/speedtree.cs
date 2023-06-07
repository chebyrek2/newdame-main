using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedtree : MonoBehaviour
{
    public GameObject Heal;
    public List<GameObject> Spawners;
    
    public ParticleSystem explosion;
    public ParticleSystem PS;              //Particle system
    private int MaxShoots = 1;
    private int _countShoot = 0;
    private void Start()
    {
        PS = Instantiate(explosion, this.gameObject.transform);
    }

    private void Update()
    {
        PS.transform.position = this.gameObject.transform.position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "aboba")
        {
            DropHeal();
            _countShoot++;
            if (_countShoot == MaxShoots)
            {
                Destroy(gameObject);
            }
        }
    }

    public void DropHeal()
    {
        Instantiate(Heal, Spawners[Random.Range(0, Spawners.Count)].transform.position, Heal.transform.rotation);

    }

}


