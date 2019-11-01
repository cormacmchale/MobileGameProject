using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    //maintain this here
    private int health = 5;
    //method to lose the heart
    public int getHealth()
    {
        return health;
    }
    public void loseAheart()
    {
        health--;
    }
    private void Update()
    {
        //check for health = 0
        if (health == 0)
        {
            //alert end of game
            Debug.Log("yo dead bitch");
        }
    }
}
