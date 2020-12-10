using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public float spawnDelay = .3f;

    float nextTimeToSpawn = 0f ;

    public GameObject car;

    public Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar() ;
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    public void SpawnCar()
    {
        int randomIndex = Random.Range(0,2);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(car, spawnPoint.position , spawnPoint.rotation);
    }
}
