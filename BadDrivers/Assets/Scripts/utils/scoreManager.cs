using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    //OverAll Score
    private int playerScore;
    private Queue<int> overallScore = new Queue<int>();
    public Text displayScore;

    //score multiplier
    public GameObject bikeCounter;

    // Update is called once per frame
    void Update()
    {
        //if there is somethinng in the queue
        if (overallScore.Count>0)
        {
            //Debug.Log(overallScore.Dequeue());
            playerScore += overallScore.Dequeue();
        }
        displayScore.text = playerScore.ToString();
    }
    // add the player score when necesscary
    public void addScore(int score)
    {
        //Debug.Log(playerScore);
        //testing
        //multiply by number of bikes in game
        if (bikeCounter.transform.childCount>0)
        {
            //Debug.Log(score * bikeCounter.transform.childCount);
            overallScore.Enqueue(score * bikeCounter.transform.childCount);
        }
        else
        {
            overallScore.Enqueue(score);
        }
    }
    public void decrementScore(int score)
    {
        overallScore.Enqueue(score*-1);
    }
    //score will need to be accessed for saving ti file
    public int returnScore()
    {
        return playerScore;
    }
}