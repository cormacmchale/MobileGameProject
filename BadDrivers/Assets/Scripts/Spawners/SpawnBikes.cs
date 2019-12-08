using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBikes : MonoBehaviour
{
    [SerializeField]
    private EnemyBicycle Bike;
    //spawn bikes into here
    [SerializeField]
    private GameObject BikeManager;

    [SerializeField]
    private bool spawnBikes = false;

    //spawning variables
    //good to have these for increasing difficulty
    [SerializeField]
    private float howOftenBetweenSpawns;
    [SerializeField]
    private float timeUntilFirstSpawn;

    // Start is called before the first frame update
    void Start()
    {
        //may not need
        if (spawnBikes)
        {
            SpawnRepeating();
        }
    }
    //spawn the trucks randomly
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
            return;//max 5 bikes on screen for now??
        }
        else
        {
            Instantiate(Bike, BikeManager.transform.position, new Quaternion(0,0,0,0), BikeManager.transform);
        }
    }
    public void spawnBIke()
    {
        //maintain 5 on screen
        //and for managing amount of bikes on screen
        if (BikeManager.transform.childCount == 5)
        {
            return;//max 5 bikes on screen for now??
        }
        else
        {
            Instantiate(Bike, BikeManager.transform.position, new Quaternion(0, 0, 0, 0), BikeManager.transform);
        }
    }
}