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

    #region Joinning Server
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }

    public override void OnJoinedLobby()
    {
        if (disconnectedScreen.activeSelf) disconnectedScreen.SetActive(false);
        connectedScreen.SetActive(true);
    }
    #endregion

    #region Leaving Server
    public override void OnDisconnected(DisconnectCause cause)
    {
        if(connectedScreen.activeSelf)  connectedScreen.SetActive(false);
        disconnectedScreen.SetActive(true);
    }
    #endregion
}
