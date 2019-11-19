using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidManager : MonoBehaviour
{
    //placeholder for angle.. so the buttonshoot script can find this every time
    //this was used for correct implementation of teh android button over lay
    //the movement buttons set the angle of movement so the shoot button can fire the bullet in
    //the correct direction
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
