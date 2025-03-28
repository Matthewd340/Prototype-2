using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] animalPrefabsTop;
    public GameObject[] animalPrefabsLeft;
    public GameObject[] animalPrefabsRight;
    private int topIndex;
    private int leftIndex;
    private int rightIndex;
    public float spawnRangeX = 20;
    public float spawnRangeZ = 17;
    public float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public float lives = 3;
    public float score = 0;
    public GameObject player;
    //array allows for multiple values to be saved under it

    // Start is called before the first frame update
    void Start()
    {                   //name                  time/delay        rate
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        //calls SpawnRandomAnimal every 1.5 seconds after 2 seconds have passed
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Lives: " + lives + " Score: " + score);

        if (lives == 0)
        {
            Destroy(player.gameObject);
        }
    }

    void SpawnRandomAnimal()
    {
        
            Vector3 spawnPosTop = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Vector3 spawnPosLeft = new Vector3(-18, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
            Vector3 spawnPosRight = new Vector3(18, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
            int topIndex = Random.Range(0, animalPrefabsTop.Length);
            int leftIndex = Random.Range(0, animalPrefabsLeft.Length);
            int rightIndex = Random.Range(0, animalPrefabsRight.Length);
            //picks an animal at random, ranging from index values 0-2
            Instantiate(animalPrefabsTop[topIndex], spawnPosTop, animalPrefabsTop[topIndex].transform.rotation);
            Instantiate(animalPrefabsLeft[leftIndex], spawnPosLeft, animalPrefabsLeft[leftIndex].transform.rotation);
            Instantiate(animalPrefabsRight[rightIndex], spawnPosRight, animalPrefabsRight[rightIndex].transform.rotation);
            //spawns the randomly selected animal        
        
    }
    
}
