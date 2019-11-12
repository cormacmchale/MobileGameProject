using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficultyIncrease : MonoBehaviour
{
    private SpawnTractors ChangeTractorSpawn;

    private void Start()
    {
        ChangeTractorSpawn = FindObjectOfType<SpawnTractors>();
    }

    public void increaseDifficulty()
    {
        ChangeTractorSpawn.increaseSpawn();
    }
}
