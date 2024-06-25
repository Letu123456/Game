using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDespawn : DespawnByDistance
{
    public override void DespawnObject()
    {
        ChickenSpawner.Instance.Despawn(transform.parent);
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.LimitDistance = 25;

    }
}
