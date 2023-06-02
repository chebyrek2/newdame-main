using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit : MonoBehaviour   
{
    public ParticleSystem PrefabAnim;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            var instance = Instantiate(PrefabAnim, transform.position, Quaternion.identity);
            instance.transform.position = transform.position;
            instance.Play();
            other.gameObject.GetComponent<hp>().Heal(20);
            Debug.Log("aiywgdasiuygdywgil");
        }


    }
}
