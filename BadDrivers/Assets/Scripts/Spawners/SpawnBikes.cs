using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBikes : MonoBehaviour
{
    //placeholders for spawning and managing bikes
    [SerializeField]
    private EnemyBicycle Bike;
    [SerializeField]
    private GameObject BikeManager;

    //testing
    [SerializeField]
    private bool spawnBikes = true;

    //spawning variables
    //good to have these for increasing difficulty
    [SerializeField]
    private float howOftenBetweenSpawns;
    [SerializeField]
    private float timeUntilFirstSpawn;

    // Start is called before the first frame update
    void Start()
    {
        //testing logic
        if (spawnBikes)
        {
            SpawnRepeating();
        }
    }
    //spawn the bikes repeatedly
    private void SpawnRepeating()
    {
        InvokeRepeating("Spawn", timeUntilFirstSpawn, howOftenBetweenSpawns);
    }
    private void Spawn()
    {
        //maintain 5 on screen
        //and for managing amount of bikes on screen
        if (BikeManager.transform.childCount == 5)
        {
            return;//max 5 bikes on screen
        }
        else
        {
            Instantiate(Bike, BikeManager.transform.position, new Quaternion(0,0,0,0), BikeManager.transform);
        }
    }
}