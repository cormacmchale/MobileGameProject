using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidManager : MonoBehaviour
{
    //placeholder for angle.. so the buttonshoot script can find this every time
    private int angle;
    public int getthisAngle()
    {
        return angle;
    }
    public void setthisAngle(int value)
    {
        angle = value;
    }
}
