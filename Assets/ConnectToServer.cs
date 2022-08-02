using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Realtime;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster(){
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        RoomOptions options = new RoomOptions();
        TypedLobby lobby = new TypedLobby("Teste",LobbyType.Default);
        PhotonNetwork.JoinOrCreateRoom("Teste",options,lobby);
    }


    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Level01");
    }
}
