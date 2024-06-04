using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl : AllBeh
{
    [SerializeField] protected StoneSpawner stoneSpaw;

    public StoneSpawner StoneSpaw { get => stoneSpaw; }

    [SerializeField] protected StoneSpawnPoint pointSpa;
    public StoneSpawnPoint PointSpa {  get => pointSpa;}
    

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadStoneSpawn();
        this.LoadPointSpawn();
    }

    protected virtual void LoadStoneSpawn()
    {
        if (this.stoneSpaw != null)
        {
            return;
        }
        this.stoneSpaw = GetComponent<StoneSpawner>();

    }

    protected virtual void LoadPointSpawn()
    {
        if (this.pointSpa != null) return;
        this.pointSpa = Transform.FindAnyObjectByType<StoneSpawnPoint>();

    }
}
