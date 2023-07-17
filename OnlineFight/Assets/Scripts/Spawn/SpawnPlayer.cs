using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject players;

    public float minX, minY, maxX, maxY;

    void Start()
    {
        Vector2 randomposition = new Vector2(Random.Range(minX, minY), Random.Range(maxX, maxY));
        PhotonNetwork.Instantiate(players.name, randomposition, Quaternion.identity);
    }

  
}
