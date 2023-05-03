using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perehod : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Lose()
    {
        SceneManager.LoadScene(2);
    }
    
        public void Menu()
        {
            SceneManager.LoadScene(0);
        }
    public void Menu2()
    {
        SceneManager.LoadScene(4);
    }
    public void Play2()
    {
        SceneManager.LoadScene(3);
    }
    public void Play3()
    {
        SceneManager.LoadScene(5);
    }

    public void Play4()
    {
        SceneManager.LoadScene(6);
    }
}
