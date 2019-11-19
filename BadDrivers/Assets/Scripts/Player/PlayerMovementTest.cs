using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovementTest : MonoBehaviour
{
    //move player speed
    public float speed = 5f;

    private float dirX;
    private float dirY;
    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * speed * Time.deltaTime;
        dirY = CrossPlatformInputManager.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x+dirX, transform.position.y+dirY);
    }
}
