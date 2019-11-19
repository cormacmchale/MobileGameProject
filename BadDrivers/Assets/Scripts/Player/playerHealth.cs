using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    //maintain this here
    private int health = 5;
 
    //return health wherever it's needed
    public int getHealth()
    {
        return health;
    }
    //method to lose a heart
    //game over logic is handled in health manager
    public void loseAheart()
    {
        health--;
    }
    //method to gain a heart
    //logic will keep hearts at 5
    public void gainAheart()
    {
        //so the player does not go above 5 hearts
        if (health >= 5)
        {
            //do nothing
            //health full
        }
        else
        {
            health++;
        }
    }
}
