using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficultyIncrease : MonoBehaviour
{
    //placeholders for spawners
    private SpawnTractors ChangeTractorSpawn;
    private SpawnRandomTruck ChangeTruckSpawn;
    private SpawnAmbulance ChangeAmbulanceSpawn;

    //almost like an observer pattern
    private void Start()
    {
        //find the spawners
        ChangeTractorSpawn = FindObjectOfType<SpawnTractors>();
        ChangeTruckSpawn = FindObjectOfType<SpawnRandomTruck>();
        ChangeAmbulanceSpawn = FindObjectOfType<SpawnAmbulance>();
    }
    //increase the difficulty by calling all increase spawn methods
    public void increaseDifficulty()
    {
        ChangeTruckSpawn.increaseSpawn();
        ChangeTractorSpawn.increaseSpawn();
        ChangeAmbulanceSpawn.increaseSpawn();
    }
}
