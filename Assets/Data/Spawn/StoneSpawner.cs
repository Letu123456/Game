using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawner : Spawner
{
    private static StoneSpawner instance;

    public static StoneSpawner Instance { get => instance; }

    public static string StoneOne = "Stone";
    protected override void Awake()
    {
        base.Awake();
        if (StoneSpawner.instance != null) Debug.LogWarning("Only 1 singleton allow to exist");
        StoneSpawner.instance = this;
    }
}
