using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class test : MonoBehaviour
{

    private FireBullet shootButton;
    // Start is called before the first frame update
    void Start()
    {
        //access the orginal shoot
        shootButton = FindObjectOfType<FireBullet>();
    }

    // Update is called once per frame
    public void shoot()
    {
        //fire a bullet using this method as before
        shootButton.firebullet();
    }
}
