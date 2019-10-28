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

    void Start()
    {
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
            //call score manager
        //do something with bike
            //call score manager
        //tractor ignored in collision Matrix
    }

}
