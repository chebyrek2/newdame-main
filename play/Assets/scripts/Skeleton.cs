using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    public GameObject Gate;
    private void OnDestroy()
    {
        Destroy(Gate);
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

        }
    }
}
