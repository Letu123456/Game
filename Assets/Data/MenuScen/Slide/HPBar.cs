using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : AllBeh
{
    [SerializeField] protected ShootAbleCtrl shootAbleCtrl;
    [SerializeField] protected slideHP slideHP;
    [SerializeField] protected FollowTaget followTarget;
    [SerializeField] protected Spawner spawner;

    protected virtual void FixedUpdate()
    {
        ShowHP();
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadSlideHP();
        LoadFollowTaget();
        LoadSpawner();

    }

    protected virtual void LoadSlideHP()
    {
        if (slideHP != null) { return; }
        this.slideHP = transform.GetComponentInChildren<slideHP>();

    }
    protected virtual void LoadFollowTaget()
    {
        if (followTarget!= null) { return; }
        this.followTarget = transform.GetComponent<FollowTaget>();

    }

    protected virtual void LoadSpawner()
    {
        if (spawner != null) { return; }
        this.spawner = transform?.parent?.parent?.GetComponent<Spawner>();

    }

    
    protected virtual void ShowHP()
    {
        if (shootAbleCtrl == null) return;
        bool isDead = this.shootAbleCtrl.DamegeReceive.IsDead();
        if (isDead) { 
            this.spawner.Despawn(transform);
            return;
        }
        float hp = this.shootAbleCtrl.DamegeReceive.HP;
        float maxHp = this.shootAbleCtrl.DamegeReceive.HPMax;
        this.slideHP.SetCurrenHP(hp);
        this.slideHP.SetMaxHP(maxHp);
    }

    public virtual void SetObjectCtrl(ShootAbleCtrl shootableObjectCtrl)
    {
        this.shootAbleCtrl = shootableObjectCtrl;
    }

    public virtual void SetFollowTarget(Transform target)
    {
        this.followTarget.SetTarget(target);
    }
}
