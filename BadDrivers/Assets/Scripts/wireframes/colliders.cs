using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//**
//from class
//**
public class colliders : MonoBehaviour
{
    // all coliders using this colour
    // use this to draw a shape to make it visible
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 0.25f);
    }
}
