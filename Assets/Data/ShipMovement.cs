using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : Movement
{

    GameData data = null;
    protected override void Start()
    {
        data = MainMenu.gameData;
        LoadGame();
    }
    public void LoadGame()
    {   
        if (data == null) return;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        worldPos = position;
        Speed = data.Speed;
    }
    protected override void FixedUpdate()
    {
       getPosMouse();
        base.FixedUpdate();
    }

    protected virtual void getPosMouse()
    {
        this.worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
        this.worldPos.z = 0f; 
    }

    //protected virtual void lookatmouse()
    //{
    //    Vector3 diff = this.worldPos - transform.parent.position;
    //    diff.Normalize();
    //    float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
    //    transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z);

    //}

    //protected virtual void MoveOb() {
    //    float interpolationFactor = Speed * Time.deltaTime;
    //    Vector3 newPos = Vector3.Lerp(transform.parent.position, this.worldPos, interpolationFactor);
    //    transform.parent.position = newPos;
    //}
}
