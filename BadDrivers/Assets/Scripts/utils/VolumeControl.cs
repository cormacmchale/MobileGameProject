using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    //access the audio manager to change settings
    private AudioManager music;

    private float Volume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        music = FindObjectOfType<AudioManager>();
        //slider = GetComponentInChildren<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        music.VolumeControl(Volume);
    }
    //not working yet
    public void SetVolume()
    {
        Debug.Log("what");
    }
}
