using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{
    public int coins = 0;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "zombie" )
        {
            DeathLogic();
        }
        
    }
    void DeathLogic()
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene(1);
        Cursor.lockState = CursorLockMode.None;
    }
}
