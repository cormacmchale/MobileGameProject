using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    //hide constructor
    private scoreManager(){}

    //OverAll Score
    public int playerScore;

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

    public void addScore(int score)
    {
        scoreQueue.Add(score);
    }

    public scoreManager getInstance()
    {
        if (this == null)
        {
            return new scoreManager();
        }
        else
        {
            return this;
        }     
    }
}
