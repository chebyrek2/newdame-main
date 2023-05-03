using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosses : MonoBehaviour
{
    public GameObject Gate;

    private void OnDestroy()
    {
        Gate.SetActive(true);
    }
}
