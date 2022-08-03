using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float sensibilidade = 100f;

    public Transform corpoDoPlayer;

    float xRotacao = 0f;
    // void Start()
    // {
    //     Cursor.lockState = CursorLockMode.Locked;
    // }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Escape)){
            Cursor.lockState = CursorLockMode.None;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        if(Cursor.lockState == CursorLockMode.Locked){
            float mouseX = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensibilidade * Time.deltaTime;

            xRotacao -= mouseY;
            xRotacao = Mathf.Clamp(xRotacao, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotacao, 0f, 0f);
            corpoDoPlayer.Rotate(Vector3.up * mouseX);
        }
    }

    
}
