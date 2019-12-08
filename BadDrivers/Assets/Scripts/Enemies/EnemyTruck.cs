using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTruck : MonoBehaviour
{
    //this script is used by the spwaner to instatiate enemy trucks
    //small logic for movement when created
    [SerializeField]
    private float truckSpeed;
    private Rigidbody2D rb;

    // access managers
    private scoreManager score;
    private healthManager health;
    private AudioManager sound;

    //placeholder for animation
    [SerializeField]
    private GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        //find the managers for correct health, score keeping and playing sounds on collision
        score = FindObjectOfType<scoreManager>();
        health = FindObjectOfType<healthManager>();
        sound = FindObjectOfType<AudioManager>();
        
        //give it a random speed
        //gameobjects managed by colliders
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * truckSpeed;
    }

    //handle logic for collisions here
    //on collision check what it collided with and call the appropriate methods on managers
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
                break;
            //error handling
            default:
                Debug.Log("You shouldn't see this, check where this bullet went");
                break;
        }
    }

}
