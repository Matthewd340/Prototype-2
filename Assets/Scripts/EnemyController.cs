using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private GameManager gameManagerScript;
    public float topBound = 20;
    public float lowerBound = -5;
    public float zBound = 25;


    void Start()
    {
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            gameManagerScript.score += 1;
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
       
        
        if (other.gameObject.CompareTag("Player"))
        {
            gameManagerScript.lives -= 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            gameManagerScript.lives -= 1;
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            gameManagerScript.lives -= 1;
            Destroy(gameObject);
        }

        if (transform.position.x > zBound)
        {
            gameManagerScript.lives -= 1;
            Destroy(gameObject);
        }
        else if (transform.position.x < -zBound)
        {
            gameManagerScript.lives -= 1;
            Destroy(gameObject);
        }
    }

    
}
