using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshSpawnObject : MonoBehaviour
{
    public GameObject[] boxes = new GameObject[2];
    public GameObject cactus;
    public GameObject[] spawnPoints = new GameObject[3];
    public GameObject[] cacSpawnPoints = new GameObject[2];

    private int spawnCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        InvokeRepeating("Spawn", 0, 1);
        InvokeRepeating("GameCountDown", 43, 1);
    }

    void Spawn()
    {
        if(Random.Range(0, 4) < 1)
        {
            Instantiate(cactus, cacSpawnPoints[Random.Range(0, 2)].transform);
        }
        Instantiate(boxes[Random.Range(0, 2)], spawnPoints[Random.Range(0, 3)].transform.position, spawnPoints[Random.Range(0, 3)].transform.rotation);
        spawnCount++;
        if(spawnCount >= 30)
        {
            CancelInvoke("Spawn");
        }
    }

    void GameCountDown()
    {
        GetComponent<cshGameEnd>().GameEnd();
        CancelInvoke("GameCountDown");
    }
}
