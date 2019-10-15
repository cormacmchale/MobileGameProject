using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomTruck : MonoBehaviour
{
    public GameObject Truck;
    public Camera main;

    private Vector3 pickRandom;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRepeating();
    }

    private void SpawnRepeating()
    {
        InvokeRepeating("Spawn", 2.0f, 1.5f);
    }

    private void Spawn()
    {
        pickRandom = new Vector3(main.transform.position.x+6, Random.Range(main.transform.position.y - 5f, main.transform.position.y + 5), main.transform.position.z+15);
        Truck.transform.position = pickRandom;
        Instantiate(Truck);
    }
}
