using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseSlide : AllBeh
{
    [SerializeField] protected Slider slider;


   

    protected override void Start()
    {
        base.Start();
        this.AddEvent();
    }
    protected virtual void FixedUpdate()
    {

    }

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadSlider();
    }

    protected virtual void LoadSlider()
    {
        if (slider != null)
        {
            return;
        }

        this.slider = GetComponent<Slider>();

    }


    protected virtual void AddEvent()
    {
        this.slider.onValueChanged.AddListener(this.OnChange);
    }

    protected abstract void OnChange(float newValue);
}
