using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public AudioClip ShootSound;
    public Transform SootPlace;

    public GameObject Pula;
    public GameObject Player;
    public GameObject Pistol;
    public GameObject Gun;
    public float Speed;
    public float Cooldown;

    private float _Cooldown;
    private bool _CanShoot = true;
    void Start()
    {
        _Cooldown = Cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (_CanShoot)
            {
                _Cooldown = Cooldown;
                AudioSource.PlayClipAtPoint(ShootSound, SootPlace.position);
                GameObject instance = Instantiate(Pula, Pistol.transform.position, Gun.transform.rotation);
                instance.GetComponent<Rigidbody>().AddForce(Pistol.transform.forward * Speed);
                _CanShoot = false;
            }

        }
        if (!_CanShoot)
        {
            _Cooldown -= Time.deltaTime;
            if (_Cooldown <= 0)
            {
                _CanShoot = true;
            }
        }
        void Audio()
        {

        }
    }
}
