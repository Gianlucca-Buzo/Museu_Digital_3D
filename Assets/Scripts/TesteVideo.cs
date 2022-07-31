using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class TesteVideo : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer videoPlayer;
    void Start()
    {
        GameObject camera = GameObject.Find("Main Camera");

        videoPlayer.url = System.IO.Path.Combine (Application.streamingAssetsPath,"myFile.mp4"); 

        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
