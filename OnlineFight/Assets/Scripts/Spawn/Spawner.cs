using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Spawner : MonoBehaviour
{
    public GameObject obj;
    public Vector2 minPos;
    public Vector2 maxPos;
    
    private float randomX;
    private float randomY;
    
    private Vector2 whereToSpawn;
    
    public float spawnDelay;
    
    float nextSpawn = 0.0f;

    private PhotonView view;



    void Start()
    {
        view = GetComponent<PhotonView>();
        
    }

    void Update()
    {
        
            if (Time.time > nextSpawn)
            {

                nextSpawn = Time.time + spawnDelay;
                randomX = Random.Range(-8, 8);
                whereToSpawn = new Vector2(Random.Range(minPos.x, maxPos.x), Random.Range(minPos.y, maxPos.y));
                GameObject Coins = Instantiate(obj, whereToSpawn, Quaternion.identity);
                //GameObject Coins = PhotonNetwork.Instantiate(obj.name, whereToSpawn, Quaternion.identity);
                //Destroy(Coins, 1.7f);
            }
        
    }
}
