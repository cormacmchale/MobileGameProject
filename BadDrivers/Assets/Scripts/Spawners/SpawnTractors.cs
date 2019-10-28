using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTractors: MonoBehaviour
{
    public EnemyTractor Tractor;
    // Start is called before the first frame update
    public GameObject TractorManager;

    [SerializeField]
    private bool spawnTractors = false;

    //spawning variables
    //good to have these for increasing difficulty
    [SerializeField]
    private float howOftenBetweenSpawns;
    [SerializeField]
    private float timeUntilFirstSpawn;

    void Start()
    {
        if (spawnTractors)
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
        //maintain 3 on screen
        if (TractorManager.transform.childCount == 3)
        {
            return;//max 3 Tractors on screen for now??
        }
        else
        {
            Instantiate(Tractor, TractorManager.transform.position, new Quaternion(0, 0, 0, 0), TractorManager.transform);
        }
    }
}
