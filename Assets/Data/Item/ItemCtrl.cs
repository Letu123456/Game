using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCtrl : AllBeh
{
    [SerializeField] protected ItemDespawn itemDespawn;
    public ItemDespawn ItemDespawn => itemDespawn;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadItemDespawn();
    }

    protected virtual void LoadItemDespawn()
    {
        if (this.itemDespawn != null) return;
        this.itemDespawn = transform.GetComponentInChildren<ItemDespawn>();
        Debug.Log(transform.name + ": LoadJunkDespawn", gameObject);
    }

}
