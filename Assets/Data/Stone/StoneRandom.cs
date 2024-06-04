using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneRandom : AllBeh
{

    [SerializeField] protected Ctrl ctrl;

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadCtrl();
    }

    protected virtual void LoadCtrl()
    {
        if(this.ctrl != null)
        {
            return;
        }
        this.ctrl = GetComponent<Ctrl>();

    }

    protected override void Start()
    {
        this.StoneSpawning();
    }

    protected virtual void StoneSpawning()
    {
        Transform ranpoint = this.ctrl.PointSpa.getRandom();
        Vector3 pos = ranpoint.position;
        Quaternion rot = transform.rotation;
        Transform prefab = this.ctrl.StoneSpaw.RandomPrefab();
        Transform obj = this.ctrl.StoneSpaw.Spawn(prefab,pos, rot);
        obj.gameObject.SetActive(true);
        Invoke(nameof(this.StoneSpawning),1f);
    }
}
