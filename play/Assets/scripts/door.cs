using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player" + "")
        {
            DeathLogic();

        }
        void DeathLogic()
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(1);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
