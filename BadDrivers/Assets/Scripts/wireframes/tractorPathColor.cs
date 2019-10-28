using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tractorPathColor : MonoBehaviour
{

    // use this to draw a shape to make it visible
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 0.25f);
    }


}
