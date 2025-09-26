using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    public float spawnTimer = 1;
    public GameObject prefabToSpawn;
    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    

    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
     if(timer > spawnTimer)

       {
        SpawnGhost();
        timer -= spawnTimer;
       }
    }


public void SpawnGhost()
    {
        Vector3 randomPosition = Random.insideUnitSphere * 3;
        randomPosition.y = 0;
        Instantiate(prefabToSpawn,randomPosition, Quaternion.identity);

    }

}