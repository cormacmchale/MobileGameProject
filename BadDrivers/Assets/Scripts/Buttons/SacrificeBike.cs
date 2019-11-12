using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SacrificeBike : MonoBehaviour
{
    private EnemyBicycle[] sacBike;
    public GameObject player;
    public void SackBike()
    {
        sacBike = FindObjectsOfType<EnemyBicycle>();
        if (sacBike.Length >= 1)
        {
            //destroy closest bike??
            Destroy(sacBike[0].gameObject);
            //call animation Manager
        }
    }
}
