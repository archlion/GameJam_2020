﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;

    public GameObject[] enemies;
    public float minTimeBtwSpawns;
    public float maxTimeBtwSpawns;
    public bool canSpawn;
    public float spawnTime;
    public int enemiesInRoom;
    public bool spawnerDone;
    public GameObject spawnerDoneGameObject;
    private bool firstSpawn=true; 

    private void Start()
    {
        Invoke("SpawnEnemy", 3f);
    }

    private void Update()
    {
        if(canSpawn)
        {
            spawnTime -= Time.deltaTime;
            if(spawnTime < 0)
            {
                canSpawn = false;
            }
        }
    }

    void SpawnEnemy()
    {
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        float timeBtwSpawns = Random.Range(minTimeBtwSpawns, maxTimeBtwSpawns);

        if(canSpawn)
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], currentPoint.transform.position, Quaternion.identity);
            enemiesInRoom++;
        }

        Invoke("SpawnEnemy", timeBtwSpawns);

        if (firstSpawn)
        {
            firstSpawn = false;
            FindObjectOfType<AudioManager>().Play("bgmusic");           //play bgmusic on first spawn
        }

            if (spawnerDone)
        {
            spawnerDoneGameObject.SetActive(true);        
        }
    }
}
