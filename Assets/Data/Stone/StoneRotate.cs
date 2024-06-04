using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneRotate : StoneAbstract
{
    [SerializeField] protected float speed = 20f;

    protected virtual void FixedUpdate()
    {
        this.Rotation();
    }

    protected virtual void Rotation()
    {
        Vector3 euler = new Vector3(0, 0, 1);
        this.stoneCtr.Model.Rotate(euler*speed*Time.fixedDeltaTime);
    }
}
