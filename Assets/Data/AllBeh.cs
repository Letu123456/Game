using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class AllBeh : MonoBehaviour
{
    // Start is called before the first frame update
    protected virtual void Reset()
    {
        this.LoadComponent();
        this.ResetValue();
    }

    protected virtual void Awake()
    {
        this.LoadComponent();
    }
    protected virtual void Start()
    {
            
    }

    protected virtual void OnEnable()
    {

    }

    protected virtual void OnDisable()
    {

    }
    protected virtual void LoadComponent()
    {
        
    }

    protected virtual void ResetValue()
    {

    }
}
