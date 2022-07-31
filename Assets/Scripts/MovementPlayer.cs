using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public CharacterController controller;


    public float speed = 8f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float distanciaDoChao = 0.4f;
    public LayerMask groundMask;

    Vector3 gravitySpeed;
    bool isGrounded;


    void Start(){
        
    }
    // Update is called once per frame
    void Update(){

        isGrounded = Physics.CheckSphere(groundCheck.position, distanciaDoChao,groundMask);

        if(isGrounded && gravitySpeed.y < 0){
            gravitySpeed.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        gravitySpeed.y += gravity * Time.deltaTime;

        controller.Move(gravitySpeed * Time.deltaTime);
    }
}

