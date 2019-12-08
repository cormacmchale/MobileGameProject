﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{

    //this class fires a bullet on the UWP version of the game
    //also reused by the android over-lay
    //will need audio manage for shoot sound
    private AudioManager shootSound;
    private void Start()
    {
        //find manager when level starts
        shootSound = FindObjectOfType<AudioManager>();
    }

    //placeholder for the bullet prefab 
    public Bullet bullet;
    // Update is called once per frame
    void Update()
    {
        //when player presses fire
        if (Input.GetKeyDown("space"))
        {
            //call method to fire a bullet
            firebullet();
        }
    }
    private void firebullet()
    {
        //return a value for direction
        int setDirection = getDirection();
        //depending on direction value add correct rotation
        shoot(setDirection);
    }
    //method that reurns a single value to be used to configure dirction the bullet should fire
    private int getDirection()
    {
        //moving right along the X axis-- shoot straight
        if (Input.GetAxis("Horizontal") > 0 && Input.GetAxis("Vertical") == 0) return 0;
        //moving right along the x axis and up along the y axis -- shoot up left
        else if (Input.GetAxis("Horizontal") > 0 && Input.GetAxis("Vertical") > 0) return 45;
        //moving up the Y axis only - more lee-way added in for x -- shoot up
        else if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") == 0) return 90;
        //moving right along the x axis and up along the y axis -- shoot down right
        else if (Input.GetAxis("Horizontal") > 0 && Input.GetAxis("Vertical") < 0) return -45;
        //moving down the Y axis only - more lee-way added in for x -- shoot down
        else if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") == 0) return -90;
        //moving backwards across the x-axis --shoot left
        else if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") < 0) return -180;
        //moving backwards accross the x axis and down the y --shoot down left
        else if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") < 0) return -135;
        //moving backwards accross the x axis and up the y --shoot down left
        else if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") < 0) return -215;
        //default - shoot straight
        else return -1;
    }
    //gives the bullet the correct position and calculated angle and instantiates the bullet for firing
    //this is called from the android button shoot also
    public void shoot(int angle)
    {
        //put the bullet back to normal before you add correct rotation
        bullet.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        //player not moving
        if (angle == -1)
        { return; }
        bullet.transform.position = transform.position;
        bullet.transform.Rotate(Vector3.forward * angle);
        //play sound effect and shoot bullet
        Instantiate(bullet);
        shootSound.playShootSound();

    }
}
