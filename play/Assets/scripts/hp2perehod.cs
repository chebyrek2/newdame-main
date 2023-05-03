using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hp2perehod : MonoBehaviour
{
    public float MaxHP = 100f;
    private float HP = 100;
    public Image HpBar;
    public ParticleSystem DestroyEffect;

    private void Start()
    {
        HP = MaxHP;
    }

    public void GetDamage(int damage)
    {
        if (tag == "Tree")
            GetComponent<Tree>().DropHeal();

        if (damage >= HP)
        {
            HP = 0;
            Death();
        }
        else
        {
            HP -= damage;
        }
        HpBar.fillAmount = HP / MaxHP;
    }

    private void Death()
    {
        if (tag == "Player")
        {
            SceneManager.LoadScene(4);
            Cursor.lockState = CursorLockMode.None;
        }
        else if (tag == "Tree")
        {


            DestroyEffect.Play();
            Destroy(gameObject);

        }
        else
            Destroy(gameObject);
    }
    public void Heal(float Hp)
    {

        if (Hp >= MaxHP - Hp)
        {
            HP = MaxHP;
        }
        else
        {
            HP += 30;
        }
        HpBar.fillAmount = HP / 100;
    }
}
