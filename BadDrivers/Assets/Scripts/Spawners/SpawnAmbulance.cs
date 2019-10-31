using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnAmbulance : MonoBehaviour
{
    //add an ambulance to the spawner
    public Ambulance Ambulance;
    public GameObject ambulanceManager;

    [SerializeField]
    private bool spawnAmbulance = false;

    //good to have these for increasing difficulty
    [SerializeField]
    private float howOftenBetweenSpawns;
    [SerializeField]
    private float timeUntilFirstSpawn;

    // Start is called before the first frame update
    void Start()
    {
        if (spawnAmbulance)
        {
            SpawnRepeating();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //spawn the trucks randomly
    private void SpawnRepeating()
    {
        InvokeRepeating("Spawn", timeUntilFirstSpawn, howOftenBetweenSpawns);
    }
    private void Spawn()
    {
        Instantiate(Ambulance,ambulanceManager.transform.position, new Quaternion(0,0,0,0) ,ambulanceManager.transform);
    }
}
