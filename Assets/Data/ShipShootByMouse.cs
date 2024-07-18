using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShootByMouse :Shooting
{
        protected override bool IsShooting()
        {
            this.isShooting = SingletonMouse.Instance.Onfight == 1;
            return this.isShooting;
        }
}
