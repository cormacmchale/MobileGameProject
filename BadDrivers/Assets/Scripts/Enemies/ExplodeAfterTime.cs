using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeAfterTime : MonoBehaviour
{
    //the amount of time the explosion object will be alive for (length of animation)
    private float lifetime = .55f;
    // Start is called before the first frame update
    void Start()
    {
        //call destory after alloted time
        Destroy(gameObject, lifetime);
    }
}
