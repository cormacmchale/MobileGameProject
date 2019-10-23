using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBicycle : MonoBehaviour
{
    [SerializeField]
    private float speed=2.0f;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //find the player
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //needs to be fixed
        //transform.position = Vector2.MoveTowards(player.transform.position, speed * Time.deltaTime);
    }
}
