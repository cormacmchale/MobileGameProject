using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTractor : MonoBehaviour
{
    //get a list of the points to follow
    private GameObject pathPoints;
    //have access to the array of transforms
    Transform[] followThis;

    //access managers
    private scoreManager score;
    private healthManager health;
    private AudioManager sound;

    //used for holder the next point in the path
    private int nextMove;

    //movement speed
    [SerializeField]
    private float speed;

    //placeholder for explosion
    [SerializeField]
    private GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        //get all options for path
        pathPoints = GameObject.Find("TractorPath");
        followThis = pathPoints.GetComponentsInChildren<Transform>();
        //just generate a random spot to move next
        nextMove = RNG();
        //access managers for update on collision
        score = FindObjectOfType<scoreManager>();
        health = FindObjectOfType<healthManager>();
        sound = FindObjectOfType<AudioManager>();

    }
    // Update is called once per frame
    void Update()
    {
        //move towards a path point
        //when you get to that location
        //move to another random point
        transform.position = Vector2.MoveTowards(transform.position, followThis[nextMove].position, speed * Time.deltaTime);
        if (transform.position.x == followThis[nextMove].position.x && transform.position.y == followThis[nextMove].position.y) nextMove=RNG();
    }
    private int RNG()
    {
        //return a random point in the array
        return Random.Range(0,followThis.Length);
    }

    //add logic for collisions
    //check collision and call appropriate methods
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
