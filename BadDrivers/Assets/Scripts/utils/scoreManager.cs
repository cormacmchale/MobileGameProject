using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    //OverAll Score
    private int playerScore;
    private Queue<int> overallScore = new Queue<int>();
    //for displaying the score
    [SerializeField]
    private Text displayScore;

    //score multiplier
    [SerializeField]
    private GameObject bikeCounter;

    // Update is called once per frame
    void Update()
    {
        //if there is somethinng in the queue
        if (overallScore.Count>0)
        {
            //add it to the player score
            playerScore += overallScore.Dequeue();
        }
        //display for user
        displayScore.text = playerScore.ToString();
    }
    //add the player score when necesscary
    public void addScore(int score)
    {
        //multiply by number of bikes in game
        if (bikeCounter.transform.childCount>0)
        {
            //add it to the queue
            overallScore.Enqueue(score * bikeCounter.transform.childCount);
        }
        else
        {
            overallScore.Enqueue(score);
        }
    }
    //if you need to lose score add a negative number to the queue
    public void decrementScore(int score)
    {
        overallScore.Enqueue(score*-1);
    }
    //score will need to be accessed for saving to file
    public int returnScore()
    {
        return playerScore;
    }
}