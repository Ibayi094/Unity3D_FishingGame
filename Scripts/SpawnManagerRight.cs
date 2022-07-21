using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerRight : MonoBehaviour
{
    ///array of fish prefabs
    public GameObject[] fishPrefabs;
    //spawn range for fish accross the screen
    private float spawnRangeZ = 5.0f;
    //spawn position on x axis
    private float spawnPosX = 15.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke "..." method at said time (in seconds) and repeat for said interval (also in seconds)
        InvokeRepeating("SpawnRandomFish", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Spawn random fish method
    void SpawnRandomFish()
    {
        //random index for fishPrefab array
        int fishIndex = Random.Range(0, fishPrefabs.Length);
        //random spawn position for fish accross z-axis from a set x-point
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));

        //creates instance of fish using random position but same rotation
        Instantiate(fishPrefabs[fishIndex], spawnPos, fishPrefabs[fishIndex].transform.rotation);
    }
}
