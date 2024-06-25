using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButton : AllBeh
{
    [SerializeField] protected Button button;


    protected override void Start()
    {
        base.Start();
        this.AddEvent();
    }

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadButton();
    }

    protected virtual void LoadButton()
    {
        if(button != null)
        {
            return;
        }

        this.button = GetComponent<Button>();

    }


    protected virtual void AddEvent()
    {
        this.button.onClick.AddListener(this.OnClick);
    }

    protected abstract void OnClick();
}
