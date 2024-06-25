using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class ShipShootByDistance : Shooting
{
    [SerializeField] protected Transform target;
    [SerializeField] protected float distance= Mathf.Infinity;
    [SerializeField] protected float minDistance = 5f;

    public virtual void SetTarget(Transform target)
    {
        this.target = target;
    }
    protected override bool IsShooting()
    {
        this.distance = Vector3.Distance(transform.position, target.position);
        this.isShooting = distance < minDistance;
        return this.isShooting;
    }
}
