using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : AllBeh
{
   private static GameCtrl instance;
    public static GameCtrl Instance { get => instance; }
    [SerializeField] protected Camera _camera;
    public Camera Camera { get => _camera;  }

    protected override void Awake()
    {
        base.Awake();
        if (GameCtrl.instance != null) Debug.LogError("Only 1 GameCtrl allow to");
        GameCtrl.instance = this;
    }

    protected override void LoadComponent()
    {
        base.LoadComponent();
        LoadCamera();

    }

    protected virtual void LoadCamera()
    {
        if (this._camera != null) return;
        this._camera = GameCtrl.FindObjectOfType<Camera>();
        
    }
}
