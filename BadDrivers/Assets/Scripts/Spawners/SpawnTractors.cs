using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnTractors : MonoBehaviour
{
    //inital value for how many tractors can be on screen at once
    private int MAXTRACTORS = 3;

    //placehoolders for spawning and managing teh tractors
    [SerializeField]
    private EnemyTractor Tractor;
    [SerializeField]
    private GameObject TractorManager;

    //for testing
    [SerializeField]
    private bool spawnTractors = false;

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
        if (spawnTractors)
        {
            SpawnRepeating();
        }
    }

    //spawn the tractors repeatedly
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
        //stop invoke
        //adjust difficulty
        //re-invoke
        if (howOftenBetweenSpawns > 2)
        {
            CancelInvoke();
            howOftenBetweenSpawns -= 2f;
            timeUntilFirstSpawn -= 2f;
            MAXTRACTORS++;
            InvokeRepeating("Spawn", timeUntilFirstSpawn, howOftenBetweenSpawns);
        }
        else
        {
            //max difficulty achieved
        }
    }
        
}
