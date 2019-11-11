using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidManager : MonoBehaviour
{
    //placeholder for angle.. so the buttonshoot script can find this every time
    private int angle = -1;
    public int getAngle()
    {
        return angle;
    }
    public void setAngle(int value)
    {
        angle = value;
    }
    private void Update()
    {
        Debug.Log(angle);
    }
}
