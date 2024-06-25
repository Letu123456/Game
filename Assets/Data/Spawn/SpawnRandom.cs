using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class SpawnRandom : AllBeh
{
    

    [SerializeField] protected SpawnerCtrl ctrl;
    [SerializeField] protected float randomDelay = 1f;
    [SerializeField] protected float randomTimer = 0f;
    [SerializeField] protected float randomLimit = 9f;
   // [SerializeField] protected int count = 0;
   

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
        this.ctrl = GetComponent<SpawnerCtrl>();

    }

    //protected override void Start()
    //{
    //    this.StoneSpawning();
    //}

    protected virtual void FixedUpdate()
    {
        this.StoneSpawning();
    }

    protected virtual void StoneSpawning()
    {

        if (this.RandomReachLimit()) return;

        this.randomTimer += Time.fixedDeltaTime;
        if (this.randomTimer < this.randomDelay) return;
        this.randomTimer = 0;

        Transform ranpoint = this.ctrl.SpawnPoint.getRandom();
        Vector3 pos = ranpoint.position;
        Quaternion rot = transform.rotation;
        Transform prefab = this.ctrl.Spawn.RandomPrefab();
        Transform obj = this.ctrl.Spawn.Spawn(ChickenSpawner.Chicken,pos, rot);
        obj.gameObject.SetActive(true);
        Invoke(nameof(this.StoneSpawning),1f);
        
    }


    protected virtual bool RandomReachLimit()
    {
         int currentJunk = this.ctrl.Spawn.SpawnedCount;
        return currentJunk >= this.randomLimit;
    }
}
