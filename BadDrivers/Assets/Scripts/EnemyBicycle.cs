using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBicycle : MonoBehaviour
{
    //find the player
    private GameObject player;

    private float outOfboundsLeftDown = -10.0f;
    private float outOfboundsUpRight = 10.0f;

    [SerializeField]
    private float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        //find the player
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.name);
        //do something with player
    }
    // Update is called once per frame
    void Update()
    {
        //will do this later while looping through the bike objects in the list of the object they spawn in
        //will work better for random movement in between chasing the player
        //needs to be fixed
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        //keep bike straight
        //looks well during Gameplay
        //also stops the bikes from being shot away
        transform.SetPositionAndRotation(transform.position, new Quaternion(0, 0, 0, 0));
        DestroyOffScreen();
    }
    //Object Management
    private void DestroyOffScreen()
    {
        //if the bike travels far enough.. then destroy it
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
