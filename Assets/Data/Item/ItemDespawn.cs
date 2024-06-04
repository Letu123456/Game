using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDespawn : DespawnByDistance
{
    public override void DespawnObject()
    {
       // base.DespawnObject();
        DropSpawn.Instance.Despawn(transform.parent);
    }
}
