using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class highScoreManager : MonoBehaviour
{
    //ui plasceholder to displat text to user
    [SerializeField]
    private Text playerScore;
    [SerializeField]
    private Text highScore;
    //placeholder for the highscores
    private string[] highscores;
    // Start is called before the first frame update
    void Start()
    {
        //highscore should be the first number in the file always
        //the main level will append the latest score
        highscores = File.ReadAllLines(Application.persistentDataPath+ "/highscore.txt");
        //so if there is only one score
        //highscores.length==1
        //display player score and high score
        if (highscores.Length == 1)
        {
            //first score is highscore
            playerScore.text = highscores[0];
            highScore.text = highscores[0];
        }
        else
        {
            //compare the two values
            //high score gets the highest score
            int playerScoreCmp = Convert.ToInt32(highscores[1]);
            int highScoreCmp = Convert.ToInt32(highscores[0]);
            if (playerScoreCmp > highScoreCmp)
            {
                highScore.text = playerScoreCmp.ToString();
                playerScore.text = playerScoreCmp.ToString();
                //alert player congradulations
            }
            else
            {
                //display regularly
                playerScore.text = highscores[1];
                highScore.text = highscores[0];
                //alert player hard luck
            }
        }
    }
    //over write the file with just the highscore in there for the new score to be appended after playing the game again
    //lower score deleted by default
    private void OnDestroy()
    {
        StreamWriter w = new StreamWriter(Application.persistentDataPath + "/highscore.txt");
        //overwrite with the highscore
        w.WriteLine(highScore.text);
        w.Close();
    }
}