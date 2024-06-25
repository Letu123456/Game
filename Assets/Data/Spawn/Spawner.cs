using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : AllBeh
{
    [SerializeField] protected Transform holder;
    [SerializeField] protected int spawnedCount = 0;
    public int SpawnedCount => spawnedCount;

    [SerializeField] protected List<Transform> prefab;
    [SerializeField] protected List<Transform> poolObj;

    protected override void LoadComponent()
    {
        
        this.LoadPrefab();
        this.LoadHolder();
    }

    protected virtual void LoadHolder()
    {
        if (this.holder != null) return;
        this.holder = transform.Find("Holder");

    }

    protected virtual void LoadPrefab()
    {
        if (prefab.Count > 0) return;
        Transform prefabObj = transform.Find("Prefab");
        foreach(Transform prefabs in prefabObj)
        {
            this.prefab.Add(prefabs);
        }

        this.HidePrefab();
    }

    protected virtual void HidePrefab()
    {
        foreach(Transform prefabs in this.prefab)
        {
            prefabs.gameObject.SetActive(false);
        }
    }

    public virtual Transform Spawn(string prefabName,Vector3 spawnPos, Quaternion spawnRot)
    {

        Transform prefab = this.getPrefabName(prefabName);
        if(prefab == null) {
            Debug.LogWarning("Prefab not found");
            return null;
        }

       
        return this.Spawn(prefab,spawnPos,spawnRot);
    }

    public virtual Transform Spawn(Transform prefab, Vector3 spawnPos, Quaternion spawnRot)
    {
        Transform newPrefab = this.GetObjectFromBool(prefab);

        newPrefab.SetPositionAndRotation(spawnPos, spawnRot);
        newPrefab.SetParent(this.holder);
        spawnedCount++;
        return newPrefab;
    }
    public virtual Transform GetObjectFromBool(Transform pre)
    {
        foreach( Transform poolObjs in this.poolObj) {
        if(poolObjs.name == pre.name) { 

                this.poolObj.Remove(poolObjs);
                return poolObjs;
            }
        }

        Transform newPre = Instantiate(pre);
        newPre.name = pre.name;
        return newPre;
    }
    public virtual void Despawn(Transform obj)
    {
        this.poolObj.Add(obj);
        obj.gameObject.SetActive(false);
        spawnedCount--; 
    }

    public virtual Transform getPrefabName(string prefabName)
    {
        foreach( Transform prefabs in this.prefab)
        {
            if(prefabs.name == prefabName) return prefabs;
        }

        return null;
    }

    public virtual Transform RandomPrefab()
    {
        int rand = Random.Range(0, this.prefab.Count);
        return this.prefab[rand];
    }
}
