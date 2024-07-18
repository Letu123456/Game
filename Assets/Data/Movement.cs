using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class Movement : AllBeh
{
    // Start is called before the first frame update
    public Vector3 worldPos;
    public float Speed = 1f;
    [SerializeField] protected float Distance = 1f;
    [SerializeField] protected float  minDistance= 10f;

    protected override void Start()
    {
       
    }

    protected virtual void FixedUpdate()
    {
       //getPosMouse();
        lookatmouse();
        MoveOb();
        
    }

    //protected virtual void getPosMouse()
    //{
    //    this.worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
    //    this.worldPos.z = 0f; 
    //}

    protected virtual void lookatmouse()
    {
        Vector3 diff = this.worldPos - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z);

    }

    protected virtual void MoveOb() {

        this.Distance = Vector3.Distance(transform.position,this.worldPos);
        if(Distance< minDistance)
        {
            return;
        }
        float interpolationFactor = Speed * Time.deltaTime;
        Vector3 newPos = Vector3.Lerp(transform.parent.position, this.worldPos, interpolationFactor);
        transform.parent.position = newPos;
    }
}
