using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class UIHandler : MonoBehaviourPunCallbacks
{
    [SerializeField] InputField createRoomTF;
    [SerializeField] InputField joinRoomTF;


    public void OnClick_CreateRooom()
    {
        PhotonNetwork.CreateRoom(createRoomTF.text, new Photon.Realtime.RoomOptions { MaxPlayers = 4 }, null);
    }

    public void OnClick_JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinRoomTF.text, null);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined Room");
    }

    public override void OnCreatedRoom()
    {
        Debug.Log("Joined Room");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("Join room failed");
    }
}
