using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonMovePlayer : MonoBehaviour
{
    //will need to access the speed of the player dynamically
    private PlayerMovement getSpeed;
    private Vector3 movement;
    private bool check = false;

    //set the angle somewhere
    private AndroidManager overlayManager;

    private void Start()
    {
        //will have to work for the moment
        getSpeed = FindObjectOfType<PlayerMovement>();
        overlayManager = FindObjectOfType<AndroidManager>();
        //set default can't shoot
        overlayManager.setthisAngle(-1);
    }
    void Update()
    {
        if (check)
        {
            addMovement();
        }
    }

    public void addMovement()
    {
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
    //possible solution?
    //this works and alters the speed based on the player speed
    public void keyDown()
    {
        switch (transform.name)
        {
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
        check = true;
    }
    public void keyUp()
    {
        overlayManager.setthisAngle(-1);
        check = false;
    }
}
