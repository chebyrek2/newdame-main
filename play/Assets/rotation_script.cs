using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_script : MonoBehaviour
{
    public GameObject GO;
    void Update()
    {
        this.transform.rotation = GO.transform.rotation;
    }
}
