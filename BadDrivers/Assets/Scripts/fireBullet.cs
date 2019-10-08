using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBullet : MonoBehaviour
{
    //placeholder for the bullet prefab 
    public bullet bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //check which direction the player is moving

        //spawn bullet in the direction
        //when player presses space
        if (Input.GetKeyDown("space"))
        {
            //give the bullet the position of the player
            //spawn the bullet in
            //these will now be called elsewhere
            //bullet.transform.position = transform.position;
            //Instantiate(bullet);
            bulletDirection(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        }
    }
    void bulletDirection(float Xmovement, float Ymovement)
    {
        //transform the bullet in whatever diection the car is moving
        //just check these values to know which direction
            //testing
            //Debug.Log(Xmovement+" "+Ymovement);
        //keeping this here for now
        //give the bullet a position
        //and create the game object
        if (Xmovement < 0)
        {
            bullet.transform.position = transform.position;
            bullet.transform.rotation = new Quaternion(0f, 45f, 0f, 0f);
            Instantiate(bullet);
        }
        //shoot left
        else
        {
            bullet.transform.position = transform.position;
            bullet.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
            Instantiate(bullet);
        }
    }
}
