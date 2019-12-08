using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //get a handle on all managers for shooting an enemy correctly
    private scoreManager score;
    private healthManager health;
    private AudioManager sound;

    //speed of bullet
    [SerializeField]
    private float thrust = 10.0f;

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
        sound = FindObjectOfType<AudioManager>();
    }

    //when the bullet collides with something 
    //call appropriate methods on managers
    void OnCollisionEnter2D(Collision2D col)
    {
        switch(col.gameObject.tag)
        {
            case "EnemyTruck":
                Instantiate(explosion, transform.position, new Quaternion(0, 0, 0, 0));
                sound.playExplosion();
                Destroy(gameObject);
                Destroy(col.gameObject);
                score.addScore(20);
                break;
            case "EnemyTractor":
                Instantiate(explosion, transform.position, new Quaternion(0, 0, 0, 0));
                sound.playExplosion();
                Destroy(gameObject);
                Destroy(col.gameObject);
                score.addScore(30);
                break;
            case "Ambulance":
                Instantiate(explosion, transform.position, new Quaternion(0, 0, 0, 0));
                sound.playExplosion();
                Destroy(gameObject);
                Destroy(col.gameObject);
                score.addScore(50);
                health.incrementHealth();
                break;
                //error handling
            default:
                Debug.Log("You shouldn't see this, check where this bullet went");
                break;
        }
    }

}
