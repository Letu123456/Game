using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

[RequireComponent(typeof(SphereCollider))]
public class ItemPickupable : ItemAbtract
{
    [SerializeField] protected SphereCollider _collider;


    public static ItemCode StringToItemCode(string itemName)
    {
        return (ItemCode)System.Enum.Parse(typeof(ItemCode), itemName);
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadTrigger();
    }


    protected virtual void LoadTrigger()
    {
        if (this._collider != null) return;
        this._collider = transform.GetComponent<SphereCollider>();
        this._collider.isTrigger = true;
        this._collider.radius = 0.1f;
        Debug.LogWarning(transform.name + " LoadTrigger", gameObject);
    }

    public virtual ItemCode GetItemCode()
    {
        return ItemPickupable.StringToItemCode(transform.parent.name);
    }

    public virtual void Picked()
    {
        this.ItemCtr.ItemDespawn.DespawnObject();
    }
}
