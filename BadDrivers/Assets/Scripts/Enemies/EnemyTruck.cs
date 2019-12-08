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

    [SerializeField]
    private GameObject explosion;

    void Start()
    {
        //find the managers for correct health and score keeping
        score = FindObjectOfType<scoreManager>();
        health = FindObjectOfType<healthManager>();
        //anims = FindObjectOfType<AnimationManager>();
        //give it a random speed
        //these game objects need to be managed
        //gameobjects managed by colliders
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * truckSpeed;
    }
    //not needed at the moment
    private void Update()
    { 

    }
    //handle logic for collisions here
    void OnCollisionEnter2D(Collision2D col)
    {
        switch (col.gameObject.tag)
        {
            case "EnemyBike":
                Instantiate(explosion, transform.position, new Quaternion(0, 0, 0, 0));
                Destroy(gameObject);
                Destroy(col.gameObject);
                health.decrementHealth();
                //animation
                break;
            case "Player":
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
