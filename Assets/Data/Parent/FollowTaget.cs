using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTaget : AllBeh
{
    [SerializeField] protected Transform target;
    [SerializeField] protected float speed = 3f;


    protected virtual void FixedUpdate()
    {
        Following();
    }
    

    protected virtual void Following()
    {
        if (target == null) return;
        transform.position=Vector3.Lerp(transform.position, target.position, speed*Time.fixedDeltaTime);
    }
}
