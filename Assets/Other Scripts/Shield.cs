using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject shieldSprite; 
    private bool isShieldActive = false;
    private float shieldTime = 5f; 
    private Coroutine shieldCoroutine;


    public bool IsShieldActive
    {
        get { return isShieldActive; }
    }
 
    public void ActivateShield()
    {
        if (isShieldActive)
        {

            shieldTime = 5f;
        }
        else
        {

            shieldCoroutine = StartCoroutine(ShieldRoutine());
        }
    }

    private IEnumerator ShieldRoutine()
    {
        isShieldActive = true;
        shieldTime = 5f;

        EnableShield(true);

        while (shieldTime > 0)
        {
            shieldTime -= Time.deltaTime;
            yield return null;
        }

        EnableShield(false);
        isShieldActive = false;
    }

    private void EnableShield(bool enable)
    {

        if (shieldSprite != null)
        {
          
            shieldSprite.SetActive(enable);
        }
    }
}