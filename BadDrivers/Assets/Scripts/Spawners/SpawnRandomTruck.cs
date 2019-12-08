using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomTruck : MonoBehaviour
{
    public EnemyTruck Truck;
    public Camera main;
    //random position to spawn truck in relation to camera
    private Vector3 pickRandom;

    //spawning variables
    //good to have these for increasing difficulty
    [SerializeField]
    private float howOftenBetweenSpawns;
    [SerializeField]
    private float timeUntilFirstSpawn;

    [SerializeField]
    private bool spawnTrucks = false;

    // Start is called before the first frame update
    void Start()
    {
        if (spawnTrucks)
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
        pickRandom = new Vector3(main.transform.position.x+6, Random.Range(main.transform.position.y - 5f, main.transform.position.y + 5), main.transform.position.z+15);
        Truck.transform.position = pickRandom;
        Instantiate(Truck, transform);
    }
    //for increasing the difficulty
    public void increaseSpawn()
    {
        howOftenBetweenSpawns += 5f;
        timeUntilFirstSpawn += 5f;
    }

}
