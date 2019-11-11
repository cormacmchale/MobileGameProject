using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonMovePlayer : MonoBehaviour
{
    //will need to access the speed of the player dynamically
    private PlayerMovement getSpeed;
    private GameObject player;
    private Vector3 movement;
    private bool check = false;

    //set the angle somewhere
    private AndroidManager overlayManager;

    private void Start()
    {
        //will have to work for the moment
        getSpeed = FindObjectOfType<PlayerMovement>();
        overlayManager = FindObjectOfType<AndroidManager>();

    }
    void Update()
    {
        if (check)
        {
            addMovement();
        }
        //Debug.Log(angle);
    }

    public void addMovement()
    {
        //add logic of checking which button got pressed here?
        switch (transform.name)
        {
            case "Up":
                movement = new Vector3(0.0f, getSpeed.getSpeedOfPlayer(), 0.0f);
                getSpeed.transform.position = getSpeed.transform.position + movement * Time.deltaTime;
                //set angle here
                //send to android Manager
                overlayManager.setAngle(90);
                break;
            case "Down":
                movement = new Vector3(0.0f, -getSpeed.getSpeedOfPlayer(), 0.0f);
                getSpeed.transform.position = getSpeed.transform.position + movement * Time.deltaTime;
                break;
            case "Right":
                movement = new Vector3(getSpeed.getSpeedOfPlayer(), 0.0f , 0.0f);
                getSpeed.transform.position = getSpeed.transform.position + movement * Time.deltaTime;
                break;
            case "Left":
                movement = new Vector3(-getSpeed.getSpeedOfPlayer(),0.0f, 0.0f);
                getSpeed.transform.position = getSpeed.transform.position + movement * Time.deltaTime;
                break;
        }
    }
    //possible solution?
    //this works and alters the speed based on the player speed
    public void keyDown()
    {
        check = true;
    }
    public void keyUp()
    {
        check = false;
        //not moving
        overlayManager.setAngle(-1);
    }
}
