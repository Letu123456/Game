using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField ] protected float LimitDistance = 30f;
    [SerializeField] protected float countDistance = 0f;
    [SerializeField] protected Camera camera1;


    protected override void FixedUpdate() 
        {
        this.Despawning();
        }

    protected override void LoadComponent()
    {
        this.LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if (this.camera1 != null) return;
        this.camera1 = Transform.FindObjectOfType<Camera>();

    }

    protected override void Despawning()
    {
        if(!CanDespawn()) return;
        DespawnObject();
    }

    public override void DespawnObject()
    {
        Destroy(transform.parent.gameObject);
    }
    protected override bool CanDespawn()
    {
        this.countDistance = Vector3.Distance(transform.position, camera1.transform.position);
        if (this.countDistance > LimitDistance) return true;
        return false;
    }
}
