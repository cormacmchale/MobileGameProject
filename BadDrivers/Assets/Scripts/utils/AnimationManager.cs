using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField]
    private Animation anim;

    public void Explosion()
    {
        anim.Play();
    }
}
