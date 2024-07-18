using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class ShipShootByDistance2 : LayEgg
{

    [SerializeField] public float Delay2 = 0.2f;
    [SerializeField] protected float time2 = 0f;

    protected override void Shoot()
    {
        base.Shoot();
    }

    protected override bool IsShooting()
    {
        time2 += Time.fixedDeltaTime;
        if (time2 > Delay2)
        {
            time2 = 0f;
            this.isShooting = true;
        }
        else
        {
            this.isShooting = false;
        }
        return this.isShooting;
    }
}
