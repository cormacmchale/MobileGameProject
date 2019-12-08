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
    //load scenes on button press
    public void audioMenu()
    {
        //load the first level when you press the start button
        //finish configuration from the unity GUI (inspector)
        SceneManager.LoadScene("AudioMenu");
    }
    public void startMenu()
    {
        //load the first level when you press the start button
        //finish configuration from the unity GUI (inspector)
        SceneManager.LoadScene("StartMenu");
    }
}
