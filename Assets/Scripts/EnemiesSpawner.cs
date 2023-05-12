using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private TimeTextCanvas timeTextCanvasScript;

    [Header("Enemies")]
    [SerializeField] private GameObject riverEnemy;
    [SerializeField] private GameObject bocaEnemy;

    private Vector3 spawnPosition;
    private bool survivedMoreThan30Seconds;
    private void Start()
    {
        Invoke("SpawnBocaEnemy", 2f);
        InvokeRepeating("Spawner", 1f, 1f);
        InvokeRepeating("SurvivedMoreThan30SecondsSpawner", 7f, 7f);
    }
    private void Spawner()
    {
        int currentTimeInMinutes = Mathf.RoundToInt(timeTextCanvasScript.currentTime);

        if (currentTimeInMinutes == 5 || currentTimeInMinutes == 10 || currentTimeInMinutes == 15)
        {
            SpawnRiverEnemy();
        }

        if(currentTimeInMinutes == 20 || currentTimeInMinutes == 25 || currentTimeInMinutes == 30)
        {
            int random = Random.Range(1, 3);

            if (random == 1)
            {
                SpawnRiverEnemy();
            }

            if(random == 2)
            {
                SpawnBocaEnemy();
            }
        }

        if(currentTimeInMinutes >= 30)
        {
            survivedMoreThan30Seconds = true;
        }
    }

    private void SurvivedMoreThan30SecondsSpawner()
    {
        if(survivedMoreThan30Seconds)
        {
            SpawnBocaEnemy();
            SpawnRiverEnemy();
        }
    }

    private void SpawnRiverEnemy()
    {
        SetSpawnPosition();
        Instantiate(riverEnemy, spawnPosition, Quaternion.identity);
    }

    private void SpawnBocaEnemy()
    {
        SetSpawnPosition();
        Instantiate(bocaEnemy, spawnPosition, Quaternion.identity);
    }

    private void SetSpawnPosition()
    {
        int random1 = Random.Range(1, 5);

        if (random1 == 1)
        {
            spawnPosition = new Vector3(-9.45f, 0);
        }

        if (random1 == 2)
        {
            spawnPosition = new Vector3(9.45f, 0);
        }

        if (random1 == 3)
        {
            spawnPosition = new Vector3(0, 5.5f);
        }

        if (random1 == 4)
        {
            spawnPosition = new Vector3(0, -5.5f);
        }
    }
}
