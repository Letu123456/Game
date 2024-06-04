using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeSender : AllBeh
{
    [SerializeField] protected int damage = 1;

    public virtual void Send(Transform obj)
    {
        DamegeReceive damageReceiver = obj.GetComponentInChildren<DamegeReceive>();
        if (damageReceiver == null) return;
        this.Send(damageReceiver);
        createImpact();
    }

    public virtual void Send(DamegeReceive damageReceiver)
    {
        damageReceiver.Deduct(this.damage);

    }

    protected virtual void createImpact()
    {
        string fxName = GetImpact();

        Vector3 hitPos = transform.position;
        Quaternion hitRot = transform.rotation;
        Transform fxImpact = ExplosionSpawn.Instance.Spawn(fxName, hitPos, hitRot);
        fxImpact.gameObject.SetActive(true);

    }

    protected virtual string GetImpact()
    {
        return ExplosionSpawn.Impact1;
    }
}
