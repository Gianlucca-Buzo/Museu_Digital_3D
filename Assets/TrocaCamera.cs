using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCamera : MonoBehaviour
{
    public GameObject Player;
    public GameObject CameraCanvas;
    public float wait_time = 14f;
    void Start()
    {
        StartCoroutine(Wait_for_intro());
        
    }

   IEnumerator Wait_for_intro() {
        yield return new WaitForSeconds(wait_time);
        Player.SetActive(true);
        CameraCanvas.SetActive(false);
    }
}
