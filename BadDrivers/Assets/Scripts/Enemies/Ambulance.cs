using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambulance : MonoBehaviour
{
    Transform[] followThis;
    private GameObject pathPoints;
    // Start is called before the first frame update

    private int firstStop;
    private int secondStop;

    private float speed = 1.5f;

    void Start()
    {
        pathPoints = GameObject.Find("AmbulancePath");
        //get all options for path
        followThis = pathPoints.GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, followThis[1].position, speed * Time.deltaTime);
    }
}
