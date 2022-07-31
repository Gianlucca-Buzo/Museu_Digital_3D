using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float sensibilidade = 100f;

    public Transform corpoDoPlayer;

    float xRotacao = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidade * Time.deltaTime;

        xRotacao -= mouseY;
        xRotacao = Mathf.Clamp(xRotacao, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotacao, 0f, 0f);
        corpoDoPlayer.Rotate(Vector3.up * mouseX);
    }
}
