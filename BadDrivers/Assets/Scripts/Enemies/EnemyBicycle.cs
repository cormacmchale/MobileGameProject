﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBicycle : MonoBehaviour
{
    //find the player
    private GameObject player;
    private float outOfboundsLeftDown = -10.0f;
    private float outOfboundsUpRight = 10.0f;
    private Quaternion reduceBikeMovement = new Quaternion();

    //for managing movement
    private Vector2 stopMovement = new Vector2(0, 0);
    public Rigidbody2D rb;

    [SerializeField]
    private float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        //find the player
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        //do something with collisions with other gameObjects
        //decrement score here
    }
    // Update is called once per frame
    void Update()
    {
        //bikes follow player
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        //keep bike straight
        //looks well during Gameplay
        transform.SetPositionAndRotation(transform.position, reduceBikeMovement);
    }
}