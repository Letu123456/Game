using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMove : Movement
{
    [SerializeField] protected Transform Ship;

    protected override void FixedUpdate()
    {

        getPosShip();
       base.FixedUpdate();
    }


    protected virtual void SetPosShip(Transform ship)
    {
        this.Ship = ship;
    }
    protected virtual void getPosShip()
    {
        this.worldPos = this.Ship.position;
        this.worldPos.z = 0f; 
    }

    
}
