using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBarSpawn : Spawner
{
    private static HPBarSpawn instance;
    public static HPBarSpawn Instance => instance;
    public static string HPBar = "CanvasHP";

    protected override void Awake()
    {
        base.Awake();
        if (HPBarSpawn.instance != null) Debug.LogError("Only 1 HPBarSpawn allow to exist");
        HPBarSpawn.instance = this;
    }
}
