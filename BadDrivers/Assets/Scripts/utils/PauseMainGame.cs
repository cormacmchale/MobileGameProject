using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMainGame : MonoBehaviour
{
    public GameObject pauseView;
    private AudioManager pauseAudio;
    //placeholder for the volume before pause
    private float pauseVolume;

    private void Start()
    {
        pauseAudio = FindObjectOfType<AudioManager>();
    }
    private void Update()
    {
        
    }
    //simple pause
    //no need to manage sound
    //time scale will handle this
    public void pauseMenu()
    {
        pauseView.SetActive(true);
        Time.timeScale = 0f;
        pauseVolume = pauseAudio.getVolume();
        pauseAudio.VolumeControl(0);
    }
    //for returning volume to previous level
    public float resumeVolume()
    {
        return pauseVolume;
    }
}
