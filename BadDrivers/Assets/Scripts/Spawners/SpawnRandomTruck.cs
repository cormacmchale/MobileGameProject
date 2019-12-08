using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomTruck : MonoBehaviour
{
    //placeholder for the truck prefab
    [SerializeField]
    private EnemyTruck Truck;
    //place bounds on the spawner
    [SerializeField]
    private Camera main;
    //random position to spawn truck in relation to camera
    private Vector3 pickRandom;

    //spawning variables
    //good to have these for increasing difficulty
    [SerializeField]
    private float howOftenBetweenSpawns;
    [SerializeField]
    private float timeUntilFirstSpawn;

    //testing
    [SerializeField]
    private bool spawnTrucks = true;

    // Start is called before the first frame update
    void Start()
    {
        //testing logic
        if (spawnTrucks)
        {
            SpawnRepeating();
        }
    }
    //spawn the trucks randomly and repeatedly
    private void SpawnRepeating()
    {
        InvokeRepeating("Spawn", timeUntilFirstSpawn, howOftenBetweenSpawns);
    }
    private void Spawn()
    {
        //random spawn in the camera bounds
        pickRandom = new Vector3(main.transform.position.x+6, Random.Range(main.transform.position.y - 5f, main.transform.position.y + 5), main.transform.position.z+15);
        Truck.transform.position = pickRandom;
        Instantiate(Truck, transform);
    }
    //for increasing the difficulty
    public void increaseSpawn()
    {
        //stop invoke
        //adjust difficulty
        //re-invoke
        if (howOftenBetweenSpawns > 1)
        {
            CancelInvoke();
            howOftenBetweenSpawns -= 1f;
            InvokeRepeating("Spawn", timeUntilFirstSpawn, howOftenBetweenSpawns);
        }
        else
        {
            //max difficulty achieved
        }
    }
}
