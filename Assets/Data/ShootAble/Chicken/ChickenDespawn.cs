using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenDespawn : DespawnByDistance
{
    
   
    public override void DespawnObject()
    {
        ChickenSpawner.Instance.Despawn(transform.parent);

       
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.LimitDistance = 20;

    }
}
