using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SacrificeBike : MonoBehaviour
{
    //a Script for sacrificing a bike.. trying to add an extra gameplay dynamic where you have to manage the bikes on screen
    //get a placholder for all the bikes on screen
    private EnemyBicycle[] sacBike;

    //this isthe onClick() method
    public void SackBike()
    {
        //first put all bikes into the array
        sacBike = FindObjectsOfType<EnemyBicycle>();
        if (sacBike.Length >= 1)
        {
            //destroy one of the bikes
            Destroy(sacBike[0].gameObject);
            //call animation Manager
        }
    }
}
