using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//**
//from class
//**
public class backgroundmanagers : MonoBehaviour
{
    // use this to draw a shape to make it visible
    // all managers using this colour
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(transform.position, 0.25f);
    }
}
