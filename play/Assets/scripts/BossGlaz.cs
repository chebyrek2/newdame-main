using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGlaz : MonoBehaviour
{
    public GameObject Player;
    public GameObject Bullet;
    public GameObject SpawnPlace;
    public float Cooldown = 1;
    private float _Cooldown;
    public float Force = 1500;

    private void Start()
    {
        _Cooldown = Cooldown;
    }

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        //Debug.DrawRay(ray.origin, ray.direction, Color.magenta, Mathf.Infinity);
        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log($"Popal v {hit.collider.gameObject.name}");
            if (_Cooldown <= 0)
            {
                if (hit.collider.gameObject.tag == "Player")
                {
                    var instance = Instantiate(Bullet, SpawnPlace.transform.position, SpawnPlace.transform.rotation);
                    Debug.Log($"Spawn at x: {instance.transform.position.x} y: {instance.transform.position.y}, z: {instance.transform.position.z}");
                    instance.GetComponent<Rigidbody>().AddForce(SpawnPlace.transform.forward * Force);
                    _Cooldown = Cooldown;
                }
            }
            else
            {
                _Cooldown -= Time.deltaTime;
            }
        }
    }
}
