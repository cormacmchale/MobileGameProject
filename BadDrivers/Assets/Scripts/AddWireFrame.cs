using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    //**
    //from class
    //**
public class AddWireFrame : MonoBehaviour
{
        // use this to draw a shape to make it visible
        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(transform.position, 0.25f);
        }
}
