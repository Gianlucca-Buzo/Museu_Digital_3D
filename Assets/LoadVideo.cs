using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LoadVideo : MonoBehaviour
{
    public GameObject canvasObject;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        canvasObject.SetActive(true);
    }
}
