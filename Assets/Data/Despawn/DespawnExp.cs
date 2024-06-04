using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnExp : DespawnByTime
{
    public override void DespawnObject()
    {
        ExplosionSpawn.Instance.Despawn(transform.parent);
    }
}
