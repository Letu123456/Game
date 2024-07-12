using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSpawn : Spawner
{
    private static DropSpawn instance;

    public static DropSpawn Instance { get => instance; }

    
    protected override void Awake()
    {
        base.Awake();
        if (DropSpawn.instance != null) Debug.LogWarning("Only 1 DropSpawn allow to exist");
        DropSpawn.instance = this;
    }

    public virtual void Drop(List<DropRate> dropList, Vector3 pos, Quaternion rot)
    {
        if(dropList.Count > 0)
        {
            ItemCode itemCode = dropList[0].itemPro.itemCode;
            Transform itemDrop = this.Spawn(itemCode.ToString(), pos, rot);
            if (itemDrop == null) return;
            itemDrop.gameObject.SetActive(true);
        }
      
    }
}
