﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private scoreManager score;
    private healthManager health;

    [SerializeField]
    private float thrust = 10.0f;
    //gameObject management
    private float outOfboundsLeftDown = -10.0f;
    private float outOfboundsUpRight = 10.0f;
    private Vector2 stopMovement = new Vector2(0,0);

    //use this to move the bullet
    public Rigidbody2D shoot;

    // Start is called before the first frame update
    void Start()
    {    
        //will control direction of bullet based of the direction the player is moving in
        //will not need anything else here
        shoot.velocity = transform.right * thrust;
        score = FindObjectOfType<scoreManager>();
        health = FindObjectOfType<healthManager>();
    }

    private void Update()
    {
        DestroyOffScreen();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log(col.gameObject.tag);
        //destroy based on name
        switch(col.gameObject.tag)
        {
            case "EnemyTruck":
                Destroy(gameObject);
                Destroy(col.gameObject);
                score.addScore(20);
                break;
            case "EnemyTractor":
                Destroy(gameObject);
                Destroy(col.gameObject);
                score.addScore(30);
                break;
            case "Ambulance":
                Destroy(gameObject);
                Destroy(col.gameObject);
                score.addScore(50);
                health.incrementHealth();
                break;
            default:
                //Debug.Log("You shouldn't see this, check where this bullet went");
                break;
        }
    }
    //Object Management
    private void DestroyOffScreen()
    {
        //after the bullet travels far enough.. then destroy it
        if (gameObject.transform.position.x < outOfboundsLeftDown || gameObject.transform.position.y < outOfboundsLeftDown)
        {
            Destroy(gameObject);
        }
        else if (gameObject.transform.position.x > outOfboundsUpRight || gameObject.transform.position.y > outOfboundsUpRight)
        {
            Destroy(gameObject);
        }
    }
}
