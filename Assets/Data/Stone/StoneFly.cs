using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneFly : ObjectFly
{
    [SerializeField] protected float min = -16f;
    [SerializeField] protected float max = 16f;
    protected override void ResetValue()
    {
        base.ResetValue();
        this.speedMove = 2;
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        GetFlyDirection();
    }

    protected virtual void GetFlyDirection()
    {
        Vector3 camPos = GameCtrl.Instance.Camera.transform.position;
        Vector3 objPos = transform.parent.position;
        camPos.x += Random.Range(min, max);
        camPos.z += Random.Range(min, max);
        Vector3 diff = camPos - objPos;
        diff.Normalize();
        float rot_z=Mathf.Atan2(diff.y, diff.x)*Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z);
        Debug.DrawLine(objPos,objPos+diff*7,Color.red,Mathf.Infinity);
    }
}
