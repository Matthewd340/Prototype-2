using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private int animalIndex;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    //array allows for multiple values to be saved under it

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        //calls SpawnRandomAnimal every 1.5 seconds after 2 seconds have passed
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            //picks an animal at random, ranging from index values 0-2
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
            //spawns the randomly selected animal        
        
    }
    
}
