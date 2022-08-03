using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MovementPlayer : MonoBehaviour
{
    public CharacterController controller;

    PhotonView view;


    public float speed = 8f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float distanciaDoChao = 0.4f;
    public LayerMask groundMask;

    Vector3 gravitySpeed;
    bool isGrounded;
    
    Rigidbody rb;


   void Awake(){
        view = GetComponent<PhotonView>();
        rb = GetComponent<Rigidbody>();
    }

    void Start(){
        if(!view.IsMine){
        	Destroy(GetComponentInChildren<Camera>().gameObject);
        	Destroy(rb);
        }
        
    }
    // Update is called once per frame
    void Update(){

        if(view.IsMine){
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
}

