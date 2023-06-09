using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class fly_animation : MonoBehaviour
{
    private hp _HP;
    private Animator Animator;
    public int Damage = 40;
    public GameObject Player;
    public GameObject Rotation;
    public GameObject EmptyHP;
    
    public GameObject Portal;
    public float Distant = 10;
    private bool Dead = false;

    //public GameObject Player;
    public GameObject Bullet;
    public GameObject SpawnPlace;
    public float Cooldown = 1;
    private float _Cooldown;
    public float Force = 1500;

    void Start()
    {

        _Cooldown = Cooldown;
        Portal.SetActive(false);
        Animator = GetComponent<Animator>();
        
    }

    void Update()
    {
        if (!Dead)
        {
            if (Vector3.Distance(transform.position, Player.transform.position) <= Distant)
            {
                if (!Dead)
                {
                    Animator.Play("Attack01");
                    if (Animator.GetBool("end anim"))
                    {
                        Player.GetComponent<hp>().GetDamage(Damage);
                        Animator.SetBool("end anim", false);
                    }
                }
            }

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
                        var instance = Instantiate(Bullet, SpawnPlace.transform.position, Rotation.transform.rotation);
                        instance.GetComponent<pula>().Damage = Damage;
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


    public void Death()
    {
        
        Animator.Play("Die");
        Portal.SetActive(true);
        Dead = true;
        Destroy(EmptyHP);
    }
}
