using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemAbtract : AllBeh
{
    [SerializeField] protected ItemCtrl itemCtr;
    public ItemCtrl ItemCtr { get => itemCtr; }

    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadItemCtrl();
    }

    protected virtual void LoadItemCtrl()
    {
        if (itemCtr != null) return;
        itemCtr = transform.parent.GetComponent<ItemCtrl>();
    }
}
