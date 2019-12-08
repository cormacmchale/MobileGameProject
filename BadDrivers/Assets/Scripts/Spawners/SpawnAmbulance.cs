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

    //spawn the trucks randomly
    private void SpawnRepeating()
    {
        InvokeRepeating("Spawn", timeUntilFirstSpawn, howOftenBetweenSpawns);
    }
    private void Spawn()
    {
        Instantiate(Ambulance,ambulanceManager.transform.position, new Quaternion(0,0,0,0) ,ambulanceManager.transform);
    }
    //for increasing the difficulty
    public void increaseSpawn()
    {
        if (timeUntilFirstSpawn <= 14)
        {
            //stop the orignal spanwer
            CancelInvoke();
            //update the values
            howOftenBetweenSpawns += 1f;
            timeUntilFirstSpawn = 3f; // so the break dosen't become too long in the incease of difficulty
            //start invoke repeating again with new values
            InvokeRepeating("Spawn", timeUntilFirstSpawn, howOftenBetweenSpawns);
        }
        else
        {
            //max difficulty achieved
            //one ambulance per difficulty increase
        }
    }
}
