using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sfxControl : MonoBehaviour
{
    //access the toggle on screen
    [SerializeField]
    private Toggle toggle;

    //access the audio manager to change settings
    private AudioManager music;
    // Start is called before the first frame update
    void Start()
    {
        music = FindObjectOfType<AudioManager>();
        //keep the settings from previous time in menu
        toggle.isOn = music.getSfxCondition();
    }

    // Update is called once per frame
    void Update()
    {
        //pass in the true false for sfx being on
        music.interactSfx(toggle.isOn);
    }
}
