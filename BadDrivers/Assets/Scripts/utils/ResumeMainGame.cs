using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeMainGame : MonoBehaviour
{
    public GameObject pauseView;
    private AudioManager pauseAudio;

    private void Start()
    {
        pauseAudio = FindObjectOfType<AudioManager>();
    }
    //simple pause
    public void ResumeGame()
    {
        pauseView.SetActive(false);
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        pauseView.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }
}
