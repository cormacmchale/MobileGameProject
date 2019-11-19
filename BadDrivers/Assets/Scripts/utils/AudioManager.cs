using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //placholders for sound
    [SerializeField]
    private AudioSource Shoot;
    [SerializeField]
    private AudioSource BackGround;

    //boolean for sound affect
    private bool sfx = true;

    //make this a singelton
    private void Awake()
    {
        GameObject[] singletonCheck = GameObject.FindGameObjectsWithTag("MusicSingleton");
        if (singletonCheck.Length > 1) Destroy(gameObject);
        //keep everything safe
        //works correctly on android
        DontDestroyOnLoad(BackGround);
        DontDestroyOnLoad(Shoot);
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
 
    }
    //methods for playing the shoot sound in other classes
    public void playShootSound()
    {
        Shoot.Play();
    }
    //method for setting the volume with a slider in another class
    public void VolumeControl(float volume)
    {
        BackGround.volume = volume;
    }
    //method for turning of sound affects
    public void muteSound()
    {
        //use boolean here
    }
}
