using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthManager : MonoBehaviour
{

    //holders for images
    public Sprite heart;
    public Image[] hearts;

    //get the players health
    private playerHealth player;
    private int remainingHearts;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playerHealth>();   
    }

    // Update is called once per frame
    void Update()
    {
        //get the amount of hearts that the player should have
        remainingHearts = player.getHealth();

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < remainingHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
    public void decrementHealth()
    {
        player.loseAheart();
    }
}