using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCtrl : AllBeh
{
    [SerializeField] protected ChickenSpawner spawn;

    public ChickenSpawner Spawn { get => spawn; }

    [SerializeField] protected StoneSpawnPoint spawnPoin;
    public StoneSpawnPoint SpawnPoint {  get => spawnPoin;}
    

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadSpawn();
        this.LoadPointSpawn();
    }

    protected virtual void LoadSpawn()
    {
        if (this.spawn != null)
        {
            return;
        }
        this.spawn = GetComponent<ChickenSpawner>();

    }

    protected virtual void LoadPointSpawn()
    {
        if (this.spawnPoin != null) return;
        this.spawnPoin = Transform.FindAnyObjectByType<StoneSpawnPoint>();

    }
}
