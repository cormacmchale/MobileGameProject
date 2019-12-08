using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class healthManager : MonoBehaviour
{

    //holders for images
    [SerializeField]
    private Sprite heart;
    [SerializeField]
    private Image[] hearts;

    //get the players health
    private playerHealth player;
    private int remainingHearts;

    //get the score manager so we can write Score to file for first
    private scoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        //gain aceess to the amount of health the player has for decision making
        player = FindObjectOfType<playerHealth>();
        //get hold of score manager for svaing score
        scoreManager = FindObjectOfType<scoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //get the amount of hearts that the player should have
        remainingHearts = player.getHealth();
        //load Game over if there is no hearts
        if (remainingHearts <= 0)
        {
            //save score to a file
            //save next time onto a new line
            StreamWriter w = File.AppendText(Application.persistentDataPath + "/highscore.txt");
            w.WriteLine(scoreManager.returnScore());
            w.Close();
            //load new scene
            SceneManager.LoadScene("GameOver");
        }
        //logic for displaying the number of hearts the player has
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
    //for calling in other scripts
    //updating on collision untilities
    public void decrementHealth()
    {
        player.loseAheart();
    }
    public void incrementHealth()
    {
        player.gainAheart();
    }
}