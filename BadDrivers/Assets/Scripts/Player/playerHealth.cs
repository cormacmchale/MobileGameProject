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
    public void gainAheart()
    {
        //so the player does not go above 5 hearts
        if (health >= 5)
        {
            //do nothing
        }
        else
        {
            health++;
        }
    }
    private void Update()
    {
        //check for health = 0
        if (health == 0)
        {
            //alert end of game
            Debug.Log("game over");
        }
    }
}
