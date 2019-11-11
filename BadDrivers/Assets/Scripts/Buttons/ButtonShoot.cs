using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonShoot : MonoBehaviour
{

    private FireBullet shootButton;
    private ButtonMovePlayer findAngle;
    // Start is called before the first frame update
    void Start()
    {
        //access the orginal shoot
        shootButton = FindObjectOfType<FireBullet>();
        findAngle = FindObjectOfType<ButtonMovePlayer>();
    }

    // Update is called once per frame
    public void shoot()
    {
        //fire a bullet using this method as before
        shootButton.shoot(findAngle.getAngle());
        Debug.Log(findAngle.getAngle());
    }
}
