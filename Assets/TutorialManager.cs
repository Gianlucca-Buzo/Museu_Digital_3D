using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex = 0;

    void Update(){

        for (int i = 0; i < popUps.Length; i++)
        {
            if(i == popUpIndex){
                popUps[popUpIndex].SetActive(true);
            }else{
                popUps[i].SetActive(false);
            }
        }

        if(popUpIndex == 0){
            if(Input.GetMouseButtonDown(0)){
                popUpIndex++;
            }
        }else if (popUpIndex == 1){
            if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow)){
                popUpIndex++;
            }
        }
    }
}
