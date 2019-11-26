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
        if (singletonCheck.Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            //keep everything safe       
            DontDestroyOnLoad(gameObject);
        }
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
    //for pausing and restarting with the same sound.. and for setting the value of the slider fomr the singleton
    public float getVolume()
    {
        return BackGround.volume;
    }
    //method for turning of sound affects
    public void muteSfx()
    {
        if (sfx)
        {
            //use boolean here
            //all sfx must go here
            Shoot.volume = 0.0f;
            sfx = false;
        }
        else
        {
            Shoot.volume = 1.0f;
        }
    }
}
