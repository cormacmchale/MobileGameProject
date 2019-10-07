using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    //dont need to perform tasks on frame refresh in the script
    public void startLevel(string sceneName)
    {
        //load the first level when you press the start button
        SceneManager.LoadScene(sceneName);
    }
}
