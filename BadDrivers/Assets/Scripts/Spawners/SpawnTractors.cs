using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnTractors : MonoBehaviour
{
    private int MAXTRACTORS = 3;
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
        if (TractorManager.transform.childCount == MAXTRACTORS)
        {
            return;//based on difficulty
        }
        else
        {
            Instantiate(Tractor, TractorManager.transform.position, new Quaternion(0, 0, 0, 0), TractorManager.transform);
        }
    }
    //for increasing the difficulty
    public void increaseSpawn()
    {
        howOftenBetweenSpawns+=5f;
        timeUntilFirstSpawn+=5f;
        MAXTRACTORS+=5;
    }
        
}
