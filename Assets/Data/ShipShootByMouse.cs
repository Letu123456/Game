using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShootByMouse :Shooting
{
    PlaySounds sounds;
   protected override void Start()
    {
        sounds = FindAnyObjectByType<PlaySounds>();
    }
    protected override bool IsShooting()
        {
        this.isShooting = SingletonMouse.Instance.Onfight == 1;
        if (this.isShooting)
            {
            sounds.playGunShot();
            }
        return this.isShooting;
        }
}
