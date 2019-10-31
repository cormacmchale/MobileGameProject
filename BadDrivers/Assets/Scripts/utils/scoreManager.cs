using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    //OverAll Score
    private int playerScore;

    BlockingCollection<int> scoreQueue;
    // Start is called before the first frame update
    void Start()
    {
        scoreQueue = new BlockingCollection<int>();
    }

    // Update is called once per frame
    void Update()
    {
        playerScore += scoreQueue.Take();
    }
    // add the player score when nesscary
    public void addScore(int score)
    {
        //testing
        Debug.Log(playerScore);
        scoreQueue.Add(score);
    }
}
