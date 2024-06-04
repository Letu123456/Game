using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMouse : MonoBehaviour
{
    private static SingletonMouse instance;

    public static SingletonMouse Instance { get => instance; }
    

    [SerializeField] protected Vector3 ratPos;

    public Vector3 RatPos { get => ratPos; }

    [SerializeField] protected float onFight;

    public float Onfight { get => onFight; }

    // Start is called before the first frame update
    void Awake()
    { if (SingletonMouse. instance != null) Debug.LogWarning("Only 1 singleton allow to exist");
       SingletonMouse. instance = this;
    }

    private void Update()
    {
        getMouseDown();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        getRatPos();
    }
    protected virtual void getMouseDown()
    {
        this.onFight = Input.GetAxis("Fire1");
    }
  protected virtual  void getRatPos()
    {
        this.ratPos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
        ratPos.z = Camera.main.nearClipPlane;
    }
}
