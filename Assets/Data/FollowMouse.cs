using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : Movement
{
    // Start is called before the first frame update
    
    

    protected override void FixedUpdate()
    {
       getPosMouse();
       
        base.FixedUpdate();
    }

    protected virtual void getPosMouse()
    {
        this.worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
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
