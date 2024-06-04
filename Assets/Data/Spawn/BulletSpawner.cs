using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{

    private static BulletSpawner instance;

    public static BulletSpawner Instance { get => instance; }

    public static string bulletOne = "Bullet";
   protected override void Awake()
    {
        base.Awake();
        if (BulletSpawner.instance != null) Debug.LogWarning("Only 1 singleton allow to exist");
         BulletSpawner.instance = this;
    }


}
