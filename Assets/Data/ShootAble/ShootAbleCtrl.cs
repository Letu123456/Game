using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootAbleCtrl : AllBeh
{
    [SerializeField] protected Transform model;
    public Transform Model { get => model; }

    [SerializeField] protected ChickenDespawn despawn;
    public ChickenDespawn Despawn { get => despawn; }

    [SerializeField] protected ShootAbleSO shootAbleSO;
    public ShootAbleSO ShootAbleSO { get => shootAbleSO; }

    [SerializeField] DamegeReceive damegeRecei;
    public DamegeReceive DamegeReceive { get => damegeRecei; }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadModel();
        this.LoadDespawn();
        this.LoadSO();
        LoadDamegeRecei();
    }

    protected virtual void LoadDamegeRecei()
    {
        if (damegeRecei != null) return;
        this.damegeRecei = transform.GetComponentInChildren<DamegeReceive>();
    }

    protected virtual void LoadModel()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
        Debug.Log(transform.name + ": LoadModel", gameObject);
    }

    protected virtual void LoadDespawn()
    {
        if (this.despawn != null) return;
        this.despawn = transform.GetComponentInChildren<ChickenDespawn>();
        Debug.Log(transform.name + ": LoadDespawn", gameObject);
    }
    protected virtual void LoadSO()
    {
        if (this.shootAbleSO != null) return;
        string resPath = "ShootAble/"+this.GetObjType()+"/" + transform.name;
        this.shootAbleSO = Resources.Load<ShootAbleSO>(resPath);
        Debug.LogWarning(transform.name + ": LoadStoneSO " + resPath, gameObject);
    }

    protected abstract string GetObjType();
   
}
