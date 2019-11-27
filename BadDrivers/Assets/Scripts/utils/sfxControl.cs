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
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(toggle.isOn);
    }
}
