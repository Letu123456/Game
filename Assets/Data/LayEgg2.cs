using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LayEgg2 : AllBeh
{
    [SerializeField] protected bool isShooting = false;
    //[SerializeField] protected Transform bullet;
    [SerializeField] protected float Delay = 0.2f;
    [SerializeField] protected float time = 0f;
   
    private void Update()
    {
        IsShooting();
        Shoot();
    }

    protected virtual void Shoot()
    {
        if (!isShooting) return;

        time += Time.fixedDeltaTime;
        if (time < Delay) return;
        time = 0f;
        UnityEngine.Vector3 spawnPos = transform.position;
        UnityEngine.Quaternion spawnRot = transform.parent.rotation;
        //spawnRot.z = 90;
        Transform newBullet = EggSpawn.Instance.Spawn(EggSpawn.egg, spawnPos, spawnRot);
        if (newBullet == null) return;
        newBullet.gameObject.SetActive(true);
        BulletCtrl buletCtrl = newBullet.GetComponent<BulletCtrl>();
        buletCtrl.Setshotter(transform.parent);


        //if (!isShooting) return;

        //time += Time.fixedDeltaTime;
        //if (time < Delay) return;
        //time = 0f;

        //foreach (Transform point in points)
        //{
        //    UnityEngine.Vector3 spawnPos = point.position;
        //    UnityEngine.Quaternion spawnRot = point.rotation;
        //    Transform newBullet = EggSpawn.Instance.Spawn(EggSpawn.egg, spawnPos, spawnRot);
        //    if (newBullet == null) continue;
        //    newBullet.gameObject.SetActive(true);
        //    BulletCtrl buletCtrl = newBullet.GetComponent<BulletCtrl>();
        //    buletCtrl.Setshotter(point);
        //}
    }

   

    protected abstract bool IsShooting();

}
