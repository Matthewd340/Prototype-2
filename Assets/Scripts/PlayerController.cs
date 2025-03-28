using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    public float speed = 5;
    public float xRange = 10;
    public float bottomRange = -2;
    public float topRange = 17;
    public GameObject[] projectilePrefabs;
    private int projectileIndex;
    Vector3 offset = new Vector3 (0, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        PositionCheck();
        //move player right using acquired horizontal input
        //boolean expression, only runs when true, boolean = true/false
       
            //detects a specific key press
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //launch projectile
            int projectileIndex = Random.Range(0, projectilePrefabs.Length);
            Instantiate(projectilePrefabs[projectileIndex], transform.position + offset, projectilePrefabs[projectileIndex].transform.rotation);
        }               //parameter         parameter           parameter
                        //object to clone   where to place      what direction
    }

    void PositionCheck()
    {
         if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //top if statement keeps player above negative xRange, bottom keeps below xRange
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.z < bottomRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, bottomRange);
        }

        if(transform.position.z > topRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, topRange);
        }
    }
}
