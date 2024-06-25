using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : AllBeh
{
    [SerializeField] protected DamegeSender damageSender;
    public DamegeSender DamageSender { get => damageSender; }

    [SerializeField] protected BulletDespawn bulletDespawn;
    public BulletDespawn BulletDespawn { get => bulletDespawn; }

    [SerializeField] protected Transform shotter;
    public Transform Shotter => shotter;

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadDamageSender();
        this.LoadBulletDespawn();
    }

    protected virtual void LoadDamageSender()
    {
        if (this.damageSender != null) return;
        this.damageSender = transform.GetComponentInChildren<DamegeSender>();
        Debug.Log(transform.name + ": LoadDamageSender", gameObject);
    }

    protected virtual void LoadBulletDespawn()
    {
        if (this.bulletDespawn != null) return;
        this.bulletDespawn = transform.GetComponentInChildren<BulletDespawn>();
        Debug.Log(transform.name + ": LoadBulletDespawn", gameObject);
    }

    public virtual void Setshotter(Transform shotter)
    {
        this.shotter = shotter;
    }

}
