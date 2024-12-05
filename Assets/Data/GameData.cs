using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int hp;
    public int maxhp;
    public float Speed;
    public float[] position;
    public int point;
    public int intShieldActive;
    public GameData(ShipMovement movement, ShootAbleDameRecei damage, ItemLooter looter, Shield shield)
    {
        position = new float[3];
        position[0] = movement.worldPos.x;
        position[1] = movement.worldPos.y;
        position[2] = movement.worldPos.z;
        Speed = movement.Speed;

        hp = damage.HP;
        maxhp = damage.HPMax;
        point = looter.point;
        if (shield.isShieldActive == true)
        {
            intShieldActive = 1;
        }
        else
        {
            intShieldActive = 0;
        }
    }
}
