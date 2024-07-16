using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAbleDameRecei : DamegeReceive
{
    [Header("Junk")]
    [SerializeField] protected ShootAbleCtrl shootAbleCtrl;
   
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadJunkCtrl();
    }

    protected virtual void LoadJunkCtrl()
    {
        if (this.shootAbleCtrl != null) return;
        this.shootAbleCtrl = transform.parent.GetComponent<ShootAbleCtrl>();
        Debug.Log(transform.name + ": LoadJunkCtrl", gameObject);
    }

    protected override void OnDead()
    {
        this.OnDeadFX();
        OnDeadDrop();
        this.shootAbleCtrl.Despawn.DespawnObject();
       
    }

    protected virtual void OnDeadDrop()
    {
        Vector3 dropPos = transform.position;
        Quaternion dropRot = transform.rotation;
        DropSpawn.Instance.Drop(this.shootAbleCtrl.ShootAbleSO.dropList, dropPos, dropRot);
    }
    protected virtual void OnDeadFX()
    {
        string fxName = this.GetOnDeadFXName();
        Transform fxOnDead = ExplosionSpawn.Instance.Spawn(fxName, transform.position, transform.rotation);
        fxOnDead.gameObject.SetActive(true);
    }

    protected virtual string GetOnDeadFXName()
    {
        return ExplosionSpawn.Exp1;
    }
    public override void Reborn()
    {
        this.hpMax = this.shootAbleCtrl.ShootAbleSO.hpMax;
        base.Reborn();
    }
}
