using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hp : MonoBehaviour
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
        if (damage >= HP)
        {
            HP = 0;
            if (tag == "Boss")
            {
                GetComponent<chest_boss_controller>().Death();
                HpBar.fillAmount = HP / MaxHP;
                return;
            }
            Death();
        }
        else
        {
            HP -= damage;
            if (tag == "Boss")
                GetComponent<chest_boss_controller>().GetDamage();

        }
        HpBar.fillAmount = HP/MaxHP;
    }
    
    private void Death()
    {
        if (tag == "Player")
        {
            SceneManager.LoadScene(2);
            Cursor.lockState = CursorLockMode.None;
        }
        else if (tag == "boom_")
        {
            GetComponent<boombach>().Death();
        }
        else if (tag == "fly")
        {
            GetComponent<fly_animation>().Death();
        }
        else if (tag == "chest_boss")
        {
            GetComponent<chest_boss_controller>().Death();
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
