using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Launcher : MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject connectedScreen;
    [SerializeField] GameObject disconnectedScreen;


    public void OnClick_ConnectBtn()
    {
        PhotonNetwork.ConnectUsingSettings(); 
    }

    public override void OnConnectedToMaster()
    { 
        connectedScreen.SetActive(true);
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        connectedScreen.SetActive(false);
        disconnectedScreen.SetActive(true);
    }
}
