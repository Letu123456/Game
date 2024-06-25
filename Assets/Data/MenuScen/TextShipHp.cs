using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextShipHp : BaseText
{
   protected virtual void FixedUpdate()
    {
        UpdateShipHP();
    }

    protected virtual void UpdateShipHP()
    {
        int hpmax = ShipCtrl.Instance.DamegeReceive.HPMax;
        int hp = ShipCtrl.Instance.DamegeReceive.HP;
        this.text.SetText(hp + "/" + hpmax);
    }
}
