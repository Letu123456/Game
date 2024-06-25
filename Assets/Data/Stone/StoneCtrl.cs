using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCtrl : AllBeh
{
    [SerializeField] protected Transform model;
    public Transform Model { get => model; }

    [SerializeField] protected StoneDespawn stoneDespawn;
    public StoneDespawn StoneDespawn { get => stoneDespawn; }

    [SerializeField] protected ShootAbleSO shootAbleSO;
    public ShootAbleSO ShootAbleSO { get => shootAbleSO; }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadModel();
        this.LoadJunkDespawn();
        this.LoadStoneSO();
    }

    protected virtual void LoadModel()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
        Debug.Log(transform.name + ": LoadModel", gameObject);
    }

    protected virtual void LoadJunkDespawn()
    {
        if (this.stoneDespawn != null) return;
        this.stoneDespawn = transform.GetComponentInChildren<StoneDespawn>();
        Debug.Log(transform.name + ": LoadJunkDespawn", gameObject);
    }
    protected virtual void LoadStoneSO()
    {
        if (this.shootAbleSO != null) return;
        string resPath = "ShootAble/Stone/" + transform.name;
        this.shootAbleSO = Resources.Load<ShootAbleSO>(resPath);
        Debug.LogWarning(transform.name + ": LoadStoneSO " + resPath, gameObject);
    }
}
