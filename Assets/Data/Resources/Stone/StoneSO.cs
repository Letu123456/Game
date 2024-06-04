using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Stone", menuName = "ScriptableObjects/Stone")]
public class StoneSO : ScriptableObject
{
    public string stoneName = "Stone";
    public int hpMax = 2;

    public List<DropRate> dropList;
}
