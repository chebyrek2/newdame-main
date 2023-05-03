using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal1 : MonoBehaviour
{
    public int NumOfScene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(NumOfScene);
            Cursor.lockState = CursorLockMode.None;
        }

    }
}
