using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    [SerializeField]
    private float thrust = 10.0f;
    public Rigidbody2D shoot;
    //private Collision2D = GameObject.getComponent<On>;

    // Start is called before the first frame update
    void Start()
    {
        //will control direction of bullet based of the direction the player is moving in
        //will not need anything else here
        shoot.velocity = transform.right * thrust;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (col.gameObject.name == "player")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Do Nothing");
        }
        else
        {
            Debug.Log("Enemey Destroyed");
            //destroy everything
            //update score here??
            //also check for ambulance
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }

}
