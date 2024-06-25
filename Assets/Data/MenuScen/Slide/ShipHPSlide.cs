using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHPSlide : BaseSlide
{

    [SerializeField] protected float maxHP = 1;
    [SerializeField] protected float currenHP = 1;
    protected override void FixedUpdate()
    {
        UpdateShipHP();
        HPShow();
    }

    protected virtual void HPShow()
    {
        float hpPercent = currenHP / maxHP;
        if(hpPercent == 0)
        {
            GameManage.isGameOver = true;
        }
        this.slider.value = hpPercent;

    }
    protected override void OnChange(float newValue)
    {

    }

    public virtual void SetMaxHP(float maxHP)
    {
        this.maxHP = maxHP;
    }

    public virtual void SetCurrenHP(float currenHP)
    {
        this.currenHP = currenHP;
    }
    

    

    protected virtual void UpdateShipHP()
    {
        int hpmax = ShipCtrl.Instance.DamegeReceive.HPMax;
        int hp = ShipCtrl.Instance.DamegeReceive.HP;
        SetMaxHP(hpmax);
        SetCurrenHP(hp);
    }
}
