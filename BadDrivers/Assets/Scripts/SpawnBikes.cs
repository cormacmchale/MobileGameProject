using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBikes : MonoBehaviour
{
    public EnemyBicycle Bike;
    public GameObject BikeManager;
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
        //maintain 5 in the list
        //hopefully
        //for (int i = 0; i <= bikesOnScreen.Count-1; i++)
        //{
        //    if (bikesOnScreen[i].transform)
        //   {
        //        Debug.Log(bikesOnScreen[i].transform.position.x);
        //    }
        //}
        //random spawn in the camera bounds
        //randomly spawn the bike in relation to player
        //add bike to list
        //list.count for knowing how many bikes on screen??
        //and for managing amount of bikes on screen
        if (BikeManager.transform.childCount == 5)
        {
            return;//max 5 bikes on screen for now??
        }
        else
        {
            Instantiate(Bike, BikeManager.transform);
        }
        //bikesOnScreen.Add(Bike);
        //manage array??
    }
}
