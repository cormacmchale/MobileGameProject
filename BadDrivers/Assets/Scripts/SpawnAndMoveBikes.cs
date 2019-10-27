using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAndMoveBikes : MonoBehaviour
{
    public EnemyBicycle Bike;
    public Camera Main;
    //spawn bikes into here
    //manage movement form here
    private List<EnemyBicycle> bikesOnScreen = new List<EnemyBicycle>();

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
        //random spawn in the camera bounds
        //randomly spawn the bike in relation to player
        //add bike to list
        //list.count for knowing how many bikes on screen??
        //and for managing amount of bikes on screen
        if (bikesOnScreen.Count == 5)
        {
            return;//max 5 bikes on screen for now??
        }
        Instantiate(Bike);
        bikesOnScreen.Add(Bike);
        //manage array??
        //bikesOnScreen.TrimExcess();
    }
}
