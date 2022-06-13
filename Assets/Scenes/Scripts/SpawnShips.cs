using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShips : MonoBehaviour
{
    public Transform[] spawnPoints;
    public float spawnTime;

    public GameObject[] Ships;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Random.Range(2, 5);

        InvokeRepeating("SpawnShip", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnShip()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);

        int objectIndex = Random.Range(0, Ships.Length);

        Instantiate(Ships[objectIndex], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }
}
