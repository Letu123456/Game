using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slideHP : BaseSlide
{
    [SerializeField] protected float maxHP = 1;
    [SerializeField] protected float currenHP = 1;
    protected override void FixedUpdate()
    {
        HPShow();
    }

    protected virtual void HPShow()
    {
        float hpPercent = currenHP / maxHP;
        this.slider.value = hpPercent;
    }
    protected override void OnChange(float newValue)
    {
        
    }

    public virtual void SetMaxHP(float maxHP)
    {
        this .maxHP = maxHP;    
    }

    public virtual void SetCurrenHP(float currenHP) 
    {
        this.currenHP = currenHP;
    }
}
