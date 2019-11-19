using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonShoot : MonoBehaviour
{
    //three objects need for correct shooting
    private FireBullet shootButton;
    private AndroidManager findAngle;
    private AudioManager playSounds;
    // Start is called before the first frame update
    void Start()
    {
        //access the orginal shoot
        //only one instnce of each can exist so logic is safe

        //this will instansiate the bullet
        shootButton = FindObjectOfType<FireBullet>();
        //android manager will have the correct angle set to shoot
        findAngle = FindObjectOfType<AndroidManager>();
        //play a shoot sound
        playSounds = FindObjectOfType<AudioManager>();
    }  
    //this is a the onClick() function
    public void Shoot()
    {
        //get the shoot script and instansiate a bullet at the angle set my movement buttons in android manager
        shootButton.shoot(findAngle.getthisAngle());
        //play a shooting sound
        playSounds.playShootSound();
    }
}
