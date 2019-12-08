using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambulance : MonoBehaviour
{
    //path to follow
    Transform[] followThis;
    private GameObject pathPoints;

    //movement variables
    private int stopOnPath = 0;
    private float speed;

    //make the abulance stop condition
    private bool go = true;

    //placeholders for the managers
    private scoreManager score;
    private healthManager health;
    private AudioManager sound;

    //placeholder for explosion
    [SerializeField]
    private GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        //set initial speed
        speed = 1.0f;
        //get the path
        pathPoints = GameObject.Find("AmbulancePath");
        //get all options for path
        followThis = pathPoints.GetComponentsInChildren<Transform>();

        //access the managers for functionality
        score = FindObjectOfType<scoreManager>();
        health = FindObjectOfType<healthManager>();
        sound = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //move slowly towards first path point
        if (go)
        {
            transform.position = Vector2.MoveTowards(transform.position, followThis[stopOnPath].position, speed * Time.deltaTime);
            //when you hit the first path point
            if (transform.position.x == followThis[stopOnPath].position.x && transform.position.y == followThis[stopOnPath].position.y)
            {
                //enter this function
                StartCoroutine(pauseAmbulance());
                //move off screen much faster
                speed = 5.0f;
                stopOnPath++;
            }
        }
    }
    //called when ambulance reaches first path
    IEnumerator pauseAmbulance()
    {
        //stop inside update method
        go = false;
        //if you have made it to the final path point
        if (stopOnPath == 1)
        {
            //destory and exit function
            Destroy(gameObject);
            yield break;
        }
        //otherwise wait for three seconds
        yield return new WaitForSeconds(3);
        //allow update to work again
        go = true;
    }

    //ambulance collisions
    //only concerned with player directly
    void OnCollisionEnter2D(Collision2D col)
    {
        switch (col.gameObject.tag)
        {
            case "Player":
                Instantiate(explosion, transform.position, new Quaternion(0, 0, 0, 0));
                sound.playExplosion();
                Destroy(gameObject);
                health.incrementHealth();
                score.addScore(50);
                break;
                //error handling
            default:
                Debug.Log("You shouldn't see this, check where this bullet went");
                break;
        }
    }
}
