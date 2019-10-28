using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTractor : MonoBehaviour
{
    //get a list of the points to follow
    private GameObject pathsPoints;
    //have access to the array of transforms
    Transform[] followThis;
    //keep the tractors still
    Quaternion stayStill = new Quaternion(0,0,0,0);

    private int nextMove;

    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        pathsPoints = GameObject.Find("TractorPath");
        //get all options for path
        followThis = pathsPoints.GetComponentsInChildren<Transform>();
        nextMove = RNG();
        //testing
        //Debug.Log(followThis.Length);
    }

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

}
