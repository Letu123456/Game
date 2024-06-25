using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BaseText : AllBeh
{
    [SerializeField] protected TextMeshProUGUI text;


    protected override void Start()
    {
        base.Start();
        
    }

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadText();
    }

    protected virtual void LoadText ()
    {
        if (text != null)
        {
            return;
        }

        this.text = GetComponent<TextMeshProUGUI>();

    }


    
}
