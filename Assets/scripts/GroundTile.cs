﻿
using UnityEngine;

public class GroundTile : MonoBehaviour
{

    GroundSpawner groundSpawner;






    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }
    void OnTriggerExit (Collider other)
    {

        groundSpawner.SpawnTile();

        Destroy(gameObject, 2);


    }

    void Update()
    {
        
    }

    public GameObject obstaclePrefab;


    void SpawnObstacle ()
    {

        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;    

        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);    

    }
}
