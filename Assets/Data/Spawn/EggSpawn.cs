using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawn : Spawner
{
    private static EggSpawn instance;

    public static EggSpawn Instance { get => instance; }

    public static string egg = "Egg";
    protected override void Awake()
    {
        base.Awake();
        if (EggSpawn.instance != null) Debug.LogWarning("Only 1 singleton allow to exist");
        EggSpawn.instance = this;
    }
}
