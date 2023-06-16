using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perehod : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(2);
    }
    public void Lose()
    {
        SceneManager.LoadScene(3);
    }
    
    public void Menu()
        {
            SceneManager.LoadScene(1);
        }
    public void Menu2()
    {
        SceneManager.LoadScene(5);
    }
    public void Play2()
    {
        SceneManager.LoadScene(4);
    }
    public void Play3()
    {
        SceneManager.LoadScene(6);
    }

    public void Play4()
    {
        SceneManager.LoadScene(7);
    }
    public void Lesson()
    {
        SceneManager.LoadScene(10);
    }
    public void Menu3()
    {
        SceneManager.LoadScene(11);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
