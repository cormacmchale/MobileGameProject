using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeMainGame : MonoBehaviour
{
    public GameObject pauseView;
    private AudioManager pauseAudio;
    private PauseMainGame resetVolume;

    private void Start()
    {
        pauseAudio = FindObjectOfType<AudioManager>();
        resetVolume = FindObjectOfType<PauseMainGame>();
    }
    //simple pause
    public void ResumeGame()
    {
        pauseView.SetActive(false);
        //return audio to value from when it was paused
        pauseAudio.VolumeControl(resetVolume.resumeVolume());
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        pauseView.SetActive(false);
        Time.timeScale = 1f;
        //return audio to value from when it was paused
        pauseAudio.VolumeControl(resetVolume.resumeVolume());
        SceneManager.LoadScene("StartMenu");
    }
}
