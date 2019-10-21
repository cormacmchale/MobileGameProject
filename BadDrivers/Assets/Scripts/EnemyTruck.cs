using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTruck : MonoBehaviour
{
    private float outOfbounds = -20.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //give it a random speed
        //these game objects need to be managed
        rb.velocity = transform.right * Random.Range(-7.5f, -2.5f);
    }

    private void Update()
    {
        DestroyOffScreen();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log(col.gameObject.name);
        //do something with player
    }

    //Object Management
    private void DestroyOffScreen()
    {
        //after the truck travels far enough.. then destroy it
        if (gameObject.transform.position.x < outOfbounds)
        {
            Destroy(gameObject);
        }
    }
}
