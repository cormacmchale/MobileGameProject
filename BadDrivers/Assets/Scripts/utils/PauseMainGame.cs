using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMainGame : MonoBehaviour
{
    public GameObject pauseView;
    private AudioManager pauseAudio;

    private void Start()
    {
        pauseAudio = FindObjectOfType<AudioManager>();
    }
    //simple pause
    public void pauseMenu()
    {
        pauseView.SetActive(true);
        Time.timeScale = 0f;
        pauseAudio.VolumeControl(0);
    }
}
