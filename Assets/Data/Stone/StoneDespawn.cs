using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneDespawn : DespawnByDistance
{
    // Start is called before the first frame update
    public override void DespawnObject()
    {
        StoneSpawner.Instance.Despawn(transform.parent);
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.LimitDistance = 20;

    }
}
