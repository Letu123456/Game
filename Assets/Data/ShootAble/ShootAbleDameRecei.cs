using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAbleDameRecei : DamegeReceive
{
    [Header("Junk")]
    [SerializeField] protected ShootAbleCtrl shootAbleCtrl;
    public GameData data = null;    
    protected override void Start()
    {
        data = MainMenu.gameData;
        LoadGame();
    }
    public void LoadGame()
    {
        if (data == null) return;
        hp = data.hp;
        hpMax = data.maxhp;
    }

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


  

}
