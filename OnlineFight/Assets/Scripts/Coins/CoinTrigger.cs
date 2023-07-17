using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CoinTrigger : MonoBehaviour
{
    private PhotonView view;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            CoinsCollect.coin++;
            Destroy(gameObject);
        }
    }

}
