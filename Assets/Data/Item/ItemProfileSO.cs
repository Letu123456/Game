using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ItemProfileSO", menuName = "ScriptableObjects/ItemProfile")]
public class ItemProfileSO : ScriptableObject
{
    public ItemCode itemCode = ItemCode.NoItem;
    public ItemType itemType = ItemType.NoType;
    public string itemName = "no-name";
    public int defaultMaxStack = 100;
    public List<ItemRecip> upgradeLevel;
}
