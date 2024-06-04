using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSpawn : Spawner
{

    private static ExplosionSpawn instance;

    public static ExplosionSpawn Instance { get => instance; }

    public static string Exp1 = "Explosion";
    public static string Impact1 = "Impact";
    protected override void Awake()
    {
        base.Awake();
        if (ExplosionSpawn.instance != null) Debug.LogWarning("Only 1 singleton allow to exist");
        ExplosionSpawn.instance = this;
    }


}
