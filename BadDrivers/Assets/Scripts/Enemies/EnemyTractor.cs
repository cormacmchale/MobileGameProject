using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTractor : MonoBehaviour
{
    //get a list of the points to follow
    private GameObject pathPoints;
    //have access to the array of transforms
    Transform[] followThis;

    //needed for gameplay updates
    private scoreManager score;
    private healthManager health;

    private int nextMove;

    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        //get all options for path
        pathPoints = GameObject.Find("TractorPath");
        followThis = pathPoints.GetComponentsInChildren<Transform>();
        //just generate a random spot to move next
        nextMove = RNG();
        //access managers for updat on collision
        score = FindObjectOfType<scoreManager>();
        health = FindObjectOfType<healthManager>();

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
    void OnCollisionEnter2D(Collision2D col)
    {
        switch (col.gameObject.tag)
        {
            case "EnemyBike":
                Destroy(gameObject);
                Destroy(col.gameObject);
                health.decrementHealth();
                //animation
                break;
            case "Player":
                Destroy(gameObject);
                health.decrementHealth();
                //animation
                break;
            default:
                //Debug.Log("You shouldn't see this, check where this bullet went");
                break;
        }
    }

}
