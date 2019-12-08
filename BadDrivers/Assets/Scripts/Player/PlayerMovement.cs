using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables for adding movement
    private Vector3 movementH;
    private Vector3 movementV;

    //this will be incremented by timer
    private float speedOfPlayer = 1.0f;

    //Update is called once per frame
    //movement based off of axis input
    void Update()
    {
        movePlayer();
    }

    private void movePlayer()
    {
        //check for an up/down input
        movementH = new Vector3(Input.GetAxis("Horizontal")* speedOfPlayer, 0.0f, 0.0f);
        transform.position = transform.position + movementH * Time.deltaTime;

        //check for a left/right input
        movementV = new Vector3(0.0f, Input.GetAxis("Vertical")*speedOfPlayer, 0.0f);
        transform.position = transform.position + movementV * Time.deltaTime;
    }
    //for incrasing from the timer
    public void increaseSpeed()
    {
        speedOfPlayer+=.5f;
    }
    //functional method
    public float getSpeedOfPlayer()
    {
        return speedOfPlayer;
    }

}