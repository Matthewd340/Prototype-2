using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    public float speed = 5;
    public float xRange = 10;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        //move player right using acquired horizontal input
        //boolean expression, only runs when true, boolean = true/false
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //top if statement keeps player above negative xRange, bottom keeps below xRange
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
            //detects a specific key press
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //launch projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }               //parameter         parameter           parameter
                        //object to clone   where to place      what direction
    }
}
