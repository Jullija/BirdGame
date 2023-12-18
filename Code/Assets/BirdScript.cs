using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody; // to establish a connection between script and body
    public float flapStrength;
    public LogicManagerScript logic;
    public bool birdIsAlive = true;


    void Start() //only at start
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    void Update() //update per frame
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
            myRigidBody.velocity = Vector2.up * flapStrength; 
        }
    }


    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        birdIsAlive = false;
    }
}
