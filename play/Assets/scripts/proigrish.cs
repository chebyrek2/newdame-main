using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class proigrish : MonoBehaviour
{
    void DeathLogic()
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene(0);
    }
}
