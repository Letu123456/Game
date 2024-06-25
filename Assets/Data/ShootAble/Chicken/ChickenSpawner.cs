using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawner : Spawner
{
    private static ChickenSpawner instance;

    public static ChickenSpawner Instance { get => instance; }

    public static string Chicken = "Chicken";
    protected override void Awake()
    {
        base.Awake();
        if (ChickenSpawner.instance != null) Debug.LogWarning("Only 1 singleton allow to exist");
        ChickenSpawner.instance = this;
    }
    public override Transform Spawn(string prefabName, Vector3 spawnPos, Quaternion spawnRot)
    {
        Transform newChicken =  base.Spawn(prefabName, spawnPos, spawnRot);
        this.AddHPBarObj(newChicken);

            return newChicken;
    }

    protected virtual void AddHPBarObj(Transform newChicken)
    {
        ShootAbleCtrl newChickenCtrl = newChicken.GetComponent<ShootAbleCtrl>();
        Transform newHPBar = HPBarSpawn.Instance.Spawn(HPBarSpawn.HPBar, newChicken.position, Quaternion.identity);
            HPBar hPBar= newHPBar.GetComponent<HPBar>();
        hPBar.SetObjectCtrl(newChickenCtrl);
        hPBar.SetFollowTarget(newChicken);
        newHPBar.gameObject.SetActive(true);

    }
}
