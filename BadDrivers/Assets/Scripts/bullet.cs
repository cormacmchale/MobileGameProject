using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    [SerializeField]
    private float thrust = 10.0f;
    public Rigidbody2D shoot;

    // Start is called before the first frame update
    void Start()
    {
        //will control direction of bullet based of the direction the player is moving in
        //will not need anything else here
        shoot.velocity = transform.right * thrust;
    }

}
