using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSpeedup : MonoBehaviour
{
    private Text timerUI;
    private float timeInSec = 0;
    private float displayTime;
    private difficultyIncrease difficultyManager;
    //Start is called before the first frame update
    private PlayerMovement player;
    private bool flagSpeed = true;

    void Start()
    {
        timerUI = GetComponent<Text>();
        player = FindObjectOfType<PlayerMovement>();
        difficultyManager = FindObjectOfType<difficultyIncrease>();
    }
    // Update is called once per frame
    void Update()
    {
        //display time for user
        timeInSec += Time.deltaTime;
        displayTime = Mathf.Floor(timeInSec);
        timerUI.text = displayTime.ToString();

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
        player.increaseSpeed();
        increaseDifficulty();
        //alert difficult script here!- pass message
        yield return new WaitForSeconds(20);
        flagSpeed = true;
    }
    //increase difficulty here accross the board
    //give player an indication
    private void increaseDifficulty()
    {
        //pass message to difficulty Manager
        difficultyManager.increaseDifficulty();
        //pass message to animation manager
    }
}