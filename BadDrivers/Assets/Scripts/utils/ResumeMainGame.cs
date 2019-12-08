using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeMainGame : MonoBehaviour
{
    //for acessing the pauseView UI panel
    [SerializeField]
    private GameObject pauseView;
    
    //get appropriate managers for preserving logic in game
    private AudioManager pauseAudio;
    private PauseMainGame resetVolume;

    private void Start()
    {
        //find managers
        pauseAudio = FindObjectOfType<AudioManager>();
        resetVolume = FindObjectOfType<PauseMainGame>();
    }
    //simple resume
    public void ResumeGame()
    {
        pauseView.SetActive(false);
        //return audio to value from when it was paused
        pauseAudio.VolumeControl(resetVolume.resumeVolume());
        Time.timeScale = 1f;
    }
    //simple return to main menu
    public void MainMenu()
    {
        pauseView.SetActive(false);
        Time.timeScale = 1f;
        //return audio to value from when it was paused
        pauseAudio.VolumeControl(resetVolume.resumeVolume());
        SceneManager.LoadScene("StartMenu");
    }
}
