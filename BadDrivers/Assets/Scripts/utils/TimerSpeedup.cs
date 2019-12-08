using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSpeedup : MonoBehaviour
{
    //variables for displaying the time
    private Text timerUI;
    private float timeInSec = 0;
    private float displayTime;
    
    //difficulty manager will have to increase difficulty globally every 20 seconds
    private difficultyIncrease difficultyManager;

    //increase speed according to timer
    private PlayerMovement player;
    private bool flagSpeed = true;

    //Start is called before the first frame update
    void Start()
    {
        //get access to required components for logic as per design spec
        timerUI = GetComponent<Text>();
        player = FindObjectOfType<PlayerMovement>();
        difficultyManager = FindObjectOfType<difficultyIncrease>();
    }
    // Update is called once per frame
    void Update()
    {
        //display time for user
        timeInSec += Time.deltaTime;
        //format correctly
        displayTime = Mathf.Floor(timeInSec);
        timerUI.text = displayTime.ToString();
        //come into this method first
        if (flagSpeed)
        {
            //increase speed on time
            StartCoroutine(increasePlayerSpeed());
        }

    }
    //this logic works, increase speed every twenty seconds
    IEnumerator increasePlayerSpeed()
    {
        flagSpeed = false;
        //alert difficult script here!- pass message
        yield return new WaitForSeconds(20);
        player.increaseSpeed();
        increaseDifficulty();
        //re-enter in update and repeat every 20 seconds
        flagSpeed = true;
    }
    //increase difficulty here accross the board
    //give player an indication
    private void increaseDifficulty()
    {
        //pass message to difficulty Manager
        difficultyManager.increaseDifficulty();
    }
}