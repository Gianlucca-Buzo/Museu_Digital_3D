using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;

    public float x;
    public float y;
    public float z;

    private void Start(){
        Vector3 position = new Vector3(x,y,z);
        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name,position,Quaternion.identity);
        player.transform.Rotate(0.0f,-97.0f,0.0f,Space.Self);
    }
}
