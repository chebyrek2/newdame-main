using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public static float Speed = 15;
    public static float MaxSpeed = 100;

    CharacterController characterController;

    Vector3 move;
    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
        //DontDestroyOnLoad(gameObject);
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        move = transform.right * horizontal + transform.forward * vertical;
        characterController.Move(move * Speed * Time.deltaTime);
        
    }
    public void SpeedPlus()
    {
        Speed = Speed * 2.2f;
        if (Speed >= MaxSpeed)
        {
            Speed = MaxSpeed;
        }
        
    }
}
