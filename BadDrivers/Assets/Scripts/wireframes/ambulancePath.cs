using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//**
//from class
//**
public class ambulancePath : MonoBehaviour
{
    // all ambulances using this colour
    // use this to draw a shape to make it visible
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, 0.25f);
    }
}
