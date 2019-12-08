using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTruck : MonoBehaviour
{
    //this script for the spwaner to find and instatiate enemy trucks

    //pass this to diffculty management system??
    //small logic for movement when created
    [SerializeField]
    private float truckSpeed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    // access managers
    private scoreManager score;
    private healthManager health;
    private AudioManager sound;

    [SerializeField]
    private GameObject explosion;

    void Start()
    {
        //find the managers for correct health and score keeping and playing sounds
        score = FindObjectOfType<scoreManager>();
        health = FindObjectOfType<healthManager>();
        sound = FindObjectOfType<AudioManager>();
        //give it a random speed
        //these game objects need to be managed
        //gameobjects managed by colliders
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * truckSpeed;
    }
    //handle logic for collisions here
    void OnCollisionEnter2D(Collision2D col)
    {
        switch (col.gameObject.tag)
        {
            case "EnemyBike":
                Instantiate(explosion, transform.position, new Quaternion(0, 0, 0, 0));
                sound.playExplosion();
                Destroy(gameObject);
                Destroy(col.gameObject);
                health.decrementHealth();

                break;
            case "Player":
                Instantiate(explosion, transform.position, new Quaternion(0, 0, 0, 0));
                sound.playExplosion();
                Destroy(gameObject);
                health.decrementHealth();
                //anims.Explosion();
                //animation
                break;
            default:
                //Debug.Log("You shouldn't see this, check where this bullet went");
                break;
        }
    }

}
