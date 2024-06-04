using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StoneAbstract : AllBeh
{
    [SerializeField] protected StoneCtrl stoneCtr;
    public StoneCtrl StoneCtr { get => stoneCtr; }

    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadStoneCtrl();
    }

    protected virtual void LoadStoneCtrl()
    {
        if (stoneCtr != null) return;
        stoneCtr = transform.parent.GetComponent<StoneCtrl>();
    }
}
