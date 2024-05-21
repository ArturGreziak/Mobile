using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject obstacle;
    [SerializeField] float spawnerRate;
    [SerializeField] float maxXpos;


    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartSpawning();
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(-maxXpos, maxXpos);

        Vector2 spawnPos = new Vector2(randomX, transform.position.y);

        Instantiate(obstacle, spawnPos, Quaternion.identity);
    }

    void StartSpawning()
    {
        InvokeRepeating("Spawn", 1f, spawnerRate);   
    }

    public void StopSpawning()
    {
        CancelInvoke("Spawn");
    }
}