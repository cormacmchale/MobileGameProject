using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonShoot : MonoBehaviour
{
    private FireBullet shootButton;
    private AndroidManager findAngle;
    // Start is called before the first frame update
    void Start()
    {
        //access the orginal shoot
        shootButton = FindObjectOfType<FireBullet>();
        findAngle = FindObjectOfType<AndroidManager>();
    }
    public void Shoot()
    {
        shootButton.shoot(findAngle.getthisAngle());
    }
}
