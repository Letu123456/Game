using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCtrl : ShootAbleCtrl
{
    private static ShipCtrl instance;
    public static ShipCtrl Instance => instance;
    [SerializeField] protected Inventory inventory;
    public Inventory Inventory => inventory;

    [SerializeField] protected Shooting shoot;
    public Shooting Shooting => shoot;

    protected override void Awake()
    {
        base.Awake();
        ShipCtrl.instance = this;
    }
    protected override string GetObjType()
    {
        return objType.NoType.ToString();
    }

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadInventory();
    }

    protected virtual void LoadInventory()
    {
        if (this.inventory != null) return;
        this.inventory = transform.GetComponentInChildren<Inventory>();
        Debug.Log(transform.name + ": LoadInventory", gameObject);
    }
}
