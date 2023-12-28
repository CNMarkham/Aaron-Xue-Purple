﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundaries
{
    // Serializable class with the borders limiting the player, 
    // it probably doesn't need to be done like this but that's how I was taught -RG
    public float leftBorder, rightBorder, bottomBorder, topBorder;
}
public class PlayerControls : MonoBehaviour
{
    // variable initializations for player's speed, projectile speed, 
    // how quickly the player can fire, and a delay before they can fire again
    public float speed;
    public float projectileForce;
    public float fireRate;
    public int currentLevel;
    private float nextFire;

    // playerHealth and score are specifically for the corresponding text objects, 
    //gameOver is used as a null condition
    public int playerHealth;
    public int score;
    public bool gameOver = false;

    // variable initializations for a moveDirection vector (zeroed on init), 
    // the Player, the projectile, and the boundary class
    private Vector2 moveDirection = Vector2.zero;
    public GameObject projectile;
    public Boundaries boundary;

    private Rigidbody myRigidBody;

    void Start()
    {
        // currentLevel and score are initialized with values on Awake
        currentLevel = 1;
        score = 0;
        myRigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // moveDirection is a 2 dimensional vector 
        // containing input data for the x and y axes
        // rigidbody is used to adjust player velocity 
        // according to moveDirection and clamp the pos using info from Boundaries
        // as long as the game is running, the player can move
        moveDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (!gameOver)
        {
            myRigidBody.velocity = moveDirection * speed;
        }
        myRigidBody.position = new Vector2(
            Mathf.Clamp(
                myRigidBody.position.x,
                boundary.leftBorder,
                boundary.rightBorder
                ),
            Mathf.Clamp(
                myRigidBody.position.y,
                boundary.bottomBorder,
                boundary.topBorder
                )
        );
    }

    void Update()
    {
        if (gameOver)
        {
            return;
        }
        // While the game is running, 
        // if the player presses space or z, 
        // and you can fire

        if ((Input.GetKey("space") || Input.GetKey("z")) && (Time.time > nextFire))
        {
            nextFire = Time.time + fireRate;

            /*****************************\
            |**** Add your code below ****|
            \*****************************/
            Instantiate(projectile, transform.position, transform.rotation);
            if (currentLevel == 4)
            {
                Vector3 upOffset = new Vector3(-0.2f, 0.2f, 0);
                Vector3 downOffset = new Vector3(0.2f, 0, 0);
                Vector3 leftOffset = new Vector3(-0.2f, 0, 0);
                Vector3 rightOffset = new Vector3(0.2f, 0, 0);
                Instantiate(projectile, transform.position + rightOffset, transform.rotation);
                Instantiate(projectile, transform.position + leftOffset, transform.rotation);
                Instantiate(projectile, transform.position + downOffset, transform.rotation);
                Instantiate(projectile, transform.position + upOffset, transform.rotation);
            }
            Instantiate(projectile, transform.position, transform.rotation);
            if (currentLevel == 5)
            {
                Vector3 Offset1 = new Vector3(-0.2f, 0.2f, 0);
                Vector3 Offset2 = new Vector3(-0.2f, -0.2f, 0);
                Vector3 Offset3 = new Vector3(0.2f, 0.2f, 0);
                Vector3 Offset4 = new Vector3(0.2f, -0.2f, 0);
                Instantiate(projectile, transform.position + Offset4, transform.rotation);
                Instantiate(projectile, transform.position + Offset3, transform.rotation);
                Instantiate(projectile, transform.position + Offset2, transform.rotation);
                Instantiate(projectile, transform.position + Offset1, transform.rotation);
            }
            Instantiate(projectile, transform.position, transform.rotation);
            if (currentLevel == 6)
            {
                Vector3 upOffset = new Vector3(0, 0, 0);
                Vector3 downOffset = new Vector3(0, 0, 0);
                Vector3 leftOffset = new Vector3(-0.2f, 0.6f, 0);
                Vector3 rightOffset = new Vector3(0.2f, 0.6f, 0);
                Instantiate(projectile, transform.position + rightOffset, transform.rotation);
                Instantiate(projectile, transform.position + leftOffset, transform.rotation);
                Instantiate(projectile, transform.position + downOffset, transform.rotation);
                Instantiate(projectile, transform.position + upOffset, transform.rotation);
            }
            if (currentLevel == 3)
            {
                Vector3 upOffset = new Vector3(0, 0,0);
                Vector3 downOffset = new Vector3(0, 0, 0);
                Vector3 leftOffset = new Vector3(0.1f, 0, 0);
                Vector3 rightOffset = new Vector3(0.2f, 0, 0);
                Instantiate(projectile, transform.position + rightOffset, transform.rotation);
                Instantiate(projectile, transform.position + leftOffset, transform.rotation);
                Instantiate(projectile, transform.position + downOffset, transform.rotation);
                Instantiate(projectile, transform.position + upOffset, transform.rotation);
            }
            if (currentLevel == 7)
            {
                Vector3 upOffset = new Vector3(0.3f, 0, 0);
                Vector3 downOffset = new Vector3(0, 0, 0);
                Vector3 leftOffset = new Vector3(0.1f, 0, 0);
                Vector3 rightOffset = new Vector3(0.4f, 0, 0);
                Instantiate(projectile, transform.position + rightOffset, transform.rotation);
                Instantiate(projectile, transform.position + leftOffset, transform.rotation);
                Instantiate(projectile, transform.position + downOffset, transform.rotation);
                Instantiate(projectile, transform.position + upOffset, transform.rotation);
            }
            if (currentLevel == 8)
            {
                Vector3 upOffset = new Vector3(0.5f, 0, 0);
                Vector3 downOffset = new Vector3(0.3f, 0, 0);
                Vector3 leftOffset = new Vector3(0.4f, 0, 0);
                Vector3 rightOffset = new Vector3(0.4f, 0, 0);
                Instantiate(projectile, transform.position + rightOffset, transform.rotation);
                Instantiate(projectile, transform.position + leftOffset, transform.rotation);
                Instantiate(projectile, transform.position + downOffset, transform.rotation);
                Instantiate(projectile, transform.position + upOffset, transform.rotation);
            }
            if (currentLevel == 9)
            {
                Vector3 upOffset = new Vector3(0.6f, 0, 0);
                Vector3 downOffset = new Vector3(0.5f, 0, 0);
                Vector3 leftOffset = new Vector3(0.4f, 0, 0);
                Vector3 rightOffset = new Vector3(0.3f, 0, 0);
                Instantiate(projectile, transform.position + rightOffset, transform.rotation);
                Instantiate(projectile, transform.position + leftOffset, transform.rotation);
                Instantiate(projectile, transform.position + downOffset, transform.rotation);
                Instantiate(projectile, transform.position + upOffset, transform.rotation);
            }
            if (currentLevel == 10)
            {
                Vector3 upOffset = new Vector3(0.5f, 0, 0);
                Vector3 downOffset = new Vector3(0.5f, 0, 0);
                Vector3 leftOffset = new Vector3(0.5f, 0, 0);
                Vector3 rightOffset = new Vector3(0.5f, 0, 0);
                Instantiate(projectile, transform.position + rightOffset, transform.rotation);
                Instantiate(projectile, transform.position + leftOffset, transform.rotation);
                Instantiate(projectile, transform.position + downOffset, transform.rotation);
                Instantiate(projectile, transform.position + upOffset, transform.rotation);
            }
        }
        /*****************************\
        |**** Add your code above ****|
        \*****************************/
        // If the playerHealth is reduced to 0, 
        // the gameOver bool is set to true, 
        // having various effects across multiple scripts
        if (playerHealth <= 0)
        {
            gameOver = true;
        }
    }


        
    


    void OnTriggerEnter(Collider other)
    {
        // If the player is hit by anything that has the tag "Hazard", 
        // the Hazard is destroyed
        // and the player health is reduced by 1
        if (other.gameObject.tag == "Hazard")
        {
            Debug.Log("Player hit!");
            Destroy(other.gameObject);
            playerHealth--;
        }
    }
}