using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenCtrl : ShootAbleCtrl
{
    protected override string GetObjType()
    {
       return objType.Chicken.ToString();
    }

   
}
