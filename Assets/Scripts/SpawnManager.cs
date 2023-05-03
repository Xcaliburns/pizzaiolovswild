using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20.0f;
    private float spawnRangeZ = 20.0f;
    private float spawnDelay = 2.0f;
    private float spawnIntervalMin = 1.0f;
    private float spawnIntervalMax = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(
            "SpawnRandomAnimal",
            spawnDelay,
            Random.Range(spawnIntervalMin, spawnIntervalMax)
        );
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(
            Random.Range(-spawnRangeX, spawnRangeX),
            0,
            spawnRangeZ
            );

        Instantiate(animalPrefabs[animalIndex],
           spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
