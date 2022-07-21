using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerPowerup : MonoBehaviour
{
    public GameObject powerupPrefab;
    //spawn range on z-axis
    private float spawnRangeZ = 5.0f;
    //spawn range on x-axis
    private float spawnRangeX = 5.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke "..." method at said time (in seconds) and repeat for said interval (also in seconds)
        InvokeRepeating("SpawnRandomPowerup", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Spawn random powerup method
    void SpawnRandomPowerup()
    {
        //random spawn position for powerup accross x- and z-axis
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));

        //creates instance of powerup using random position but same rotation
        Instantiate(powerupPrefab, spawnPos, powerupPrefab.transform.rotation);
    }
}
