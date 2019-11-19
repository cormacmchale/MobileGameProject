using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    //add the slider in here to access
    public Slider slider;

    //access the audio manager to change settings
    private AudioManager music;

    // Start is called before the first frame update
    void Start()
    {
        music = FindObjectOfType<AudioManager>();
        //slider = GetComponentInChildren<Slider>();
    }
    // Update is called once per frame
    //set the value of volume to the slider value
    void Update()
    {
        music.VolumeControl(slider.value);
    }
}
