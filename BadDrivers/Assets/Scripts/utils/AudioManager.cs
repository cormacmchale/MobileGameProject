using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource Shoot;
    [SerializeField]
    private AudioSource BackGround;

    //make this a singelton
    private void Awake()
    {
        GameObject[] singletonCheck = GameObject.FindGameObjectsWithTag("MusicSingleton");
        if (singletonCheck.Length > 1) Destroy(gameObject);
        //keep everything safe
        DontDestroyOnLoad(BackGround);
        DontDestroyOnLoad(Shoot);
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
 
    }
    public void playShootSound()
    {
        Shoot.Play();
    }
    public void VolumeControl(float volume)
    {
        BackGround.volume = volume;
    }
}
