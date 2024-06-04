using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFly : AllBeh
{
    // Start is called before the first frame update
    [SerializeField] protected int speedMove = 20;
    [SerializeField] protected Vector3 direction = Vector3.right;


    private void Update()
    {
        transform.parent.Translate(this.direction * this.speedMove * Time.deltaTime);
    }
}
