using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class ButtonMovePlayer : MonoBehaviour
{

    //this script is used on the android overlay buttons for player movement
    //will need to access the speed of the player
    private PlayerMovement getSpeed;
    //apply a movement speed
    private Vector3 movement;

    //logic for movinf only when the button is down
    private bool check = false;

    //set the angle here for the shoot buttons
    private AndroidManager overlayManager;

    private void Start()
    {
        //only one instance in game so no logic confusion
        getSpeed = FindObjectOfType<PlayerMovement>();
        overlayManager = FindObjectOfType<AndroidManager>();
        //set default can't shoot
        overlayManager.setthisAngle(-1);
    }
    void Update()
    {
        //apply the movement while a key is being pressed
        if (check)
        {
            addMovement();
        }
    }

    public void addMovement()
    {

        //apply correct movement for button press
        switch (transform.name)
        {
            case "Up":
                movement = new Vector3(0.0f, getSpeed.getSpeedOfPlayer(), 0.0f);
                getSpeed.transform.position = getSpeed.transform.position + movement * Time.deltaTime;
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
            case "UpLeft":
                movement = new Vector3(-getSpeed.getSpeedOfPlayer(), getSpeed.getSpeedOfPlayer(), 0.0f);
                getSpeed.transform.position = getSpeed.transform.position + movement * Time.deltaTime;
                break;
            case "UpRight":
                movement = new Vector3(getSpeed.getSpeedOfPlayer(), getSpeed.getSpeedOfPlayer(), 0.0f);
                getSpeed.transform.position = getSpeed.transform.position + movement * Time.deltaTime;
                break;
            case "DownRight":
                movement = new Vector3(getSpeed.getSpeedOfPlayer(), -getSpeed.getSpeedOfPlayer(), 0.0f);
                getSpeed.transform.position = getSpeed.transform.position + movement * Time.deltaTime;
                break;
            case "DownLeft":
                movement = new Vector3(-getSpeed.getSpeedOfPlayer(), -getSpeed.getSpeedOfPlayer(), 0.0f);
                getSpeed.transform.position = getSpeed.transform.position + movement * Time.deltaTime;
                break;
        }
    }
    //this works and alters the speed based on the player speed
    public void keyDown()
    {
        switch (transform.name)
        {
            //set the angle for button shoot in the android manager
            //now handled with cross platform input manager
            case "Up":
                overlayManager.setthisAngle(90);
                break;
            case "Down":
                overlayManager.setthisAngle(-90);
                break;
            case "Right":
                overlayManager.setthisAngle(0);
                break;
            case "Left":
                overlayManager.setthisAngle(-180);
                break;
            case "UpLeft":
                overlayManager.setthisAngle(-215);
                break;
            case "UpRight":
                overlayManager.setthisAngle(45);
                break;
            case "DownRight":
                overlayManager.setthisAngle(-45);
                break;
            case "DownLeft":
                overlayManager.setthisAngle(-135);
                break;
        }
        //move while the player pressesa button
        check = true;
    }
    //this method will set the movement condidtion to false when a player stops pressing a key
    public void keyUp()
    {
        //-1 means not moving and button shoot wont work
        overlayManager.setthisAngle(-1);
        check = false;
    }
}
