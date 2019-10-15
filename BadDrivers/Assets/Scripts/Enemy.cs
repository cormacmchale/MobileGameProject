using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        //not needed
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        //if (col.gameObject.name == "player")
        //{
        //If the GameObject's name matches the one you suggest, output this message in the console
        Debug.Log(col.gameObject.name);
        //}
        //something for bullet
        //something for player
    }
}
