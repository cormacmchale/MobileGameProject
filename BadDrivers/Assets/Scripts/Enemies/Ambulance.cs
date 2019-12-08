using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambulance : MonoBehaviour
{
    Transform[] followThis;
    private GameObject pathPoints;
    // Start is called before the first frame update

    private int stopOnPath = 0;
    private float speed;

    //make the abulance stop condition
    private bool go = true;

    //placeholders for the managers
    private scoreManager score;
    private healthManager health;
    private AudioManager sound;

    [SerializeField]
    private GameObject explosion;

    void Start()
    {
        speed = 1.0f;
        pathPoints = GameObject.Find("AmbulancePath");
        //get all options for path
        followThis = pathPoints.GetComponentsInChildren<Transform>();
        new WaitForSeconds(200);

        score = FindObjectOfType<scoreManager>();
        health = FindObjectOfType<healthManager>();
        sound = FindObjectOfType<AudioManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (go)
        {
            transform.position = Vector2.MoveTowards(transform.position, followThis[stopOnPath].position, speed * Time.deltaTime);
            if (transform.position.x == followThis[stopOnPath].position.x && transform.position.y == followThis[stopOnPath].position.y)
            {
                StartCoroutine(pauseAmbulance());
                speed = 5.0f;
                stopOnPath++;
            }
        }
    }
    //wait for a few seconds
    //destroy when moving to new path
    IEnumerator pauseAmbulance()
    {
        go = false;
        if (stopOnPath == 1)
        {
            Destroy(gameObject);
            yield break;
        }
        yield return new WaitForSeconds(3);
        go = true;
    }

    //ambulane collisions
    void OnCollisionEnter2D(Collision2D col)
    {
        switch (col.gameObject.tag)
        {
            case "Player":
                //animation
                Instantiate(explosion, transform.position, new Quaternion(0, 0, 0, 0));
                sound.playExplosion();
                Destroy(gameObject);
                health.incrementHealth();
                score.addScore(50);
                //health manager
                break;
            default:
                //Debug.Log("You shouldn't see this, check where this bullet went");
                break;
        }
    }
}
