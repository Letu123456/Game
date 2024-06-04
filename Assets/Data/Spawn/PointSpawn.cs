using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PointSpawn : AllBeh
{
    [SerializeField] protected List<Transform> points;

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadPoint();
    }


    protected virtual void LoadPoint()
    {
        if (this.points.Count > 0) return;
        foreach (Transform t in transform) { 
        this.points.Add(t);
        }
    }

    public virtual Transform getRandom()
    {
        int rand = Random.Range(0, this.points.Count);
        return this.points[rand];
    }
}
