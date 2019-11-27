using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{   //placholders for sound
    [SerializeField]
    private AudioSource Shoot;
    [SerializeField]
    private AudioSource BackGround;
    [SerializeField]
    private AudioSource Explosion;
    //for keeping track of the sounds being set on or off
    private bool sfxCondition = true;
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
    //for pausing and restarting with the same sound.. and for setting the value of the slider from the singleton
    public float getVolume()
    {
        return BackGround.volume;
    }
    //method for turning of sound affects
    public void interactSfx(bool sfxToggle)
    {
        if (sfxToggle)
        {
            //use boolean here
            //all sfx audio must change here
            Shoot.volume = 1.0f;
            sfxCondition = true;
        }
        else //teh toggle is set to false - unticked
        {
            //mute all sounds
            Shoot.volume = 0.0f;
            sfxCondition = false;
        }
    }
    //set the toggle to the singleton value when it entes the menu
    public bool getSfxCondition()
    {
        return sfxCondition;
    }
}
