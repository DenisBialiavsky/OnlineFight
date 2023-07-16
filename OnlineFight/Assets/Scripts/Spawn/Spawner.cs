using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;
    public Vector2 minPos;
    public Vector2 maxPos;
    private float randomX;
    private float randomY;
    Vector2 whereToSpawn;
    public float spawnDelay;
    float nextSpawn = 0.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn) 
        {
            nextSpawn = Time.time + spawnDelay;
            randomX = Random.Range(-8, 8);
            whereToSpawn = new Vector2(Random.Range(minPos.x, maxPos.x), Random.Range(minPos.y, maxPos.y));
            GameObject Coins = Instantiate(obj, whereToSpawn, Quaternion.identity);
            //Destroy(Coins, 1.7f);
        }
    }
}
