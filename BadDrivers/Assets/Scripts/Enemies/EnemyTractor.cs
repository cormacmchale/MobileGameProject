using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTractor : MonoBehaviour
{
    //get a list of the points to follow
    private GameObject pathPoints;
    //have access to the array of transforms
    Transform[] followThis;
    //keep the tractors still
    Quaternion stayStill = new Quaternion(0,0,0,0);

    public scoreManager score;
    public healthManager health;

    private int nextMove;

    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        pathPoints = GameObject.Find("TractorPath");
        //get all options for path
        followThis = pathPoints.GetComponentsInChildren<Transform>();
        nextMove = RNG();
        //find score manager for bikes
        score = FindObjectOfType<scoreManager>();
        health = FindObjectOfType<healthManager>();

    }
    private bool go = true;
    // Update is called once per frame
    void Update()
    {
        transform.rotation = stayStill;
        transform.position = Vector2.MoveTowards(transform.position, followThis[nextMove].position, speed * Time.deltaTime);
        if (transform.position.x == followThis[nextMove].position.x && transform.position.y == followThis[nextMove].position.y) nextMove=RNG();
    }
    private int RNG()
    {
        //return a random point in the array
        return Random.Range(0,followThis.Length);
    }
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
                //animation
                Destroy(gameObject);
                health.decrementHealth();
                //health manager
                break;
            default:
                //Debug.Log("You shouldn't see this, check where this bullet went");
                break;
        }
    }

}
