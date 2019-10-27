using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField]
    private float thrust = 10.0f;
    private float outOfboundsLeftDown = -10.0f;
    private float outOfboundsUpRight = 10.0f;

    public Rigidbody2D shoot;
    //private Collision2D = GameObject.getComponent<On>;

    // Start is called before the first frame update
    void Start()
    {
        //will control direction of bullet based of the direction the player is moving in
        //will not need anything else here
        shoot.velocity = transform.right * thrust;
    }

    private void Update()
    {
        DestroyOffScreen();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log(col.gameObject.tag);
        //destroy based on name
        switch(col.gameObject.tag)
        {
            case "EnemyTruck":
                Destroy(gameObject);
                Destroy(col.gameObject);
                //score keeper here?
                break;
            case "EnemyBike":
                Destroy(gameObject);
                Destroy(col.gameObject);
                //score keeper here?
                break;
            default:
                //Debug.Log("You shouldn't see this, check where this bullet went");
                break;
        }
    }
    //Object Management
    private void DestroyOffScreen()
    {
        //after the bullet travels far enough.. then destroy it
        if (gameObject.transform.position.x < outOfboundsLeftDown || gameObject.transform.position.y < outOfboundsLeftDown)
        {
            Destroy(gameObject);
        }
        else if (gameObject.transform.position.x > outOfboundsUpRight || gameObject.transform.position.y > outOfboundsUpRight)
        {
            Destroy(gameObject);
        }
    }

}
