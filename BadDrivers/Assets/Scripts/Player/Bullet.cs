using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //get a handle on all managers for shooting an enemy
    private scoreManager score;
    private healthManager health;
    private AudioManager audio;

    [SerializeField]
    private float thrust = 10.0f;
    //gameObject management
    private float outOfboundsLeftDown = -10.0f;
    private float outOfboundsUpRight = 10.0f;
    private Vector2 stopMovement = new Vector2(0,0);

    //use this to move the bullet
    public Rigidbody2D shoot;

    //placeholder for the explosion
    [SerializeField]
    private GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {    
        //will control direction of bullet based of the direction the player is moving in
        //will not need anything else here
        shoot.velocity = transform.right * thrust;
        //only one instance of these managers
        score = FindObjectOfType<scoreManager>();
        health = FindObjectOfType<healthManager>();
        audio = FindObjectOfType<AudioManager>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log(col.gameObject.tag);
        //destroy based on name
        switch(col.gameObject.tag)
        {
            case "EnemyTruck":
                Instantiate(explosion, transform.position, new Quaternion(0, 0, 0, 0));
                audio.playExplosion();
                Destroy(gameObject);
                Destroy(col.gameObject);
                score.addScore(20);
                break;
            case "EnemyTractor":
                Instantiate(explosion, transform.position, new Quaternion(0, 0, 0, 0));
                audio.playExplosion();
                Destroy(gameObject);
                Destroy(col.gameObject);
                score.addScore(30);
                break;
            case "Ambulance":
                Instantiate(explosion, transform.position, new Quaternion(0, 0, 0, 0));
                audio.playExplosion();
                Destroy(gameObject);
                Destroy(col.gameObject);
                score.addScore(50);
                health.incrementHealth();
                break;
            default:
                //Debug.Log("You shouldn't see this, check where this bullet went");
                break;
        }
    }

}
