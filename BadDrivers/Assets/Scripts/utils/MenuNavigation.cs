using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    //dont need to perform tasks on frame refresh in the script
    public void startLevel()
    {
        //load the first level when you press the start button
        //finish configuration from the unity GUI (inspector)
        SceneManager.LoadScene("MainLevel");
    }
    public void pauseMenu()
    {
        SceneManager.LoadScene("PauseMenu");
    }
    public void startMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
