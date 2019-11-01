using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTruck : MonoBehaviour
{
    //pass this to diffculty management system??
    [SerializeField]
    private float truckSpeed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    public scoreManager score;

    void Start()
    {
        //find score manager for bikes

        score = FindObjectOfType<scoreManager>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        //give it a random speed
        //these game objects need to be managed
        rb.velocity = transform.right * truckSpeed;
    }

    private void Update()
    { 

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log(col.gameObject.name);

        //do something with player
        //call healthManager
        //do something with bike
        //call score manager
        //tractor ignored in collision Matrix

        switch (col.gameObject.tag)
        {
            case "EnemyBike":
                Destroy(gameObject);
                Destroy(col.gameObject);
                score.decrementScore(100);
                //animation
                break;
            case "Player":
                //animation
                //health manager
                break;
            default:
                //Debug.Log("You shouldn't see this, check where this bullet went");
                break;
        }
    }

}
