using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowShip : Movement
{
    [SerializeField] protected Transform Ship;

    protected override void FixedUpdate()
    {
       getPosShip();
       
        base.FixedUpdate();
    }


    protected virtual void SetPosShip(Transform ship)
    {
        this.Ship = ship;
    }
    protected virtual void getPosShip()
    {
        this.worldPos = this.Ship.position;
        this.worldPos.z = 0f; 
    }

    //protected virtual void lookatmouse()
    //{
    //    Vector3 diff = this.worldPos - transform.parent.position;
    //    diff.Normalize();
    //    float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
    //    transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z);

    //}

    //protected virtual void MoveOb() {
    //    float interpolationFactor = Speed * Time.deltaTime;
    //    Vector3 newPos = Vector3.Lerp(transform.parent.position, this.worldPos, interpolationFactor);
    //    transform.parent.position = newPos;
    //}
}
