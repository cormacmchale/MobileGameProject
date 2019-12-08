using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMainGame : MonoBehaviour
{
    //get a handle on pause menu UI
    [SerializeField]
    private GameObject pauseView;

    //audio handling
    private AudioManager pauseAudio;
    //placeholder for the volume before pause
    private float pauseVolume;

    private void Start()
    {
        //get the manager
        pauseAudio = FindObjectOfType<AudioManager>();
    }
    //simple pause
    //need to manage sound
    public void pauseMenu()
    {
        //show pause view
        pauseView.SetActive(true);
        //stop game
        Time.timeScale = 0f;
        //save volume
        pauseVolume = pauseAudio.getVolume();
        //turn off sound
        pauseAudio.VolumeControl(0);
    }
    //for returning volume to previous level
    public float resumeVolume()
    {
        return pauseVolume;
    }
}
