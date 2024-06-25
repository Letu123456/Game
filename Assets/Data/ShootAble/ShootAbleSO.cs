using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ShootAble", menuName = "ScriptableObjects/ShootAble")]
public class ShootAbleSO : ScriptableObject
{
    public string objName = "ShootAble";
    public objType objType;
    public int hpMax = 2;

    public List<DropRate> dropList;
}
