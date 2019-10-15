using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTruck : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //give it a random speed
        //these game objects need to be managed
        rb.velocity = transform.right * Random.Range(-10.0f, -5.0f);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //not needed
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        //if (col.gameObject.name == "player")
        //{
        //If the GameObject's name matches the one you suggest, output this message in the console
        Debug.Log(col.gameObject.name);
        //}
        //something for player
    }
}
