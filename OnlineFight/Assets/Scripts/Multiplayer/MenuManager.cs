using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviourPunCallbacks
{
    public TMP_InputField createInput;
    public TMP_InputField joinInput;

    [SerializeField] private TMP_InputField inputField;

    [SerializeField] private TextMeshProUGUI textName;

    private void Start()
    {
        inputField.text = PlayerPrefs.GetString("name");
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.ConnectUsingSettings();
        textName.text = PlayerPrefs.GetString("name");
        PhotonNetwork.NickName = textName.text;
    }
    public void CreateRoom()
    {
        SaveName();
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.CreateRoom(createInput.text, roomOptions);

    }

    public void JoinRoom()
    {
        SaveName();
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }

    private void SaveName()
    {
        PlayerPrefs.SetString("name", textName.text);
        PhotonNetwork.NickName = PlayerPrefs.GetString("name");
    }
}
