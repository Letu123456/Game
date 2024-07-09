using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject shieldSprite; // Reference to the shield sprite GameObject
    private bool isShieldActive = false;
    private float shieldTime = 5f; // Shield duration in seconds
    private Coroutine shieldCoroutine;


    public bool IsShieldActive
    {
        get { return isShieldActive; }
    }
    // Method to activate the shield
    public void ActivateShield()
    {
        if (isShieldActive)
        {
            // If the shield is already active, reset the timer
            shieldTime = 5f;
        }
        else
        {
            // If the shield is not active, start the coroutine
            shieldCoroutine = StartCoroutine(ShieldRoutine());
        }
    }

    private IEnumerator ShieldRoutine()
    {
        isShieldActive = true;
        shieldTime = 5f;
        
        // Activate the shield (e.g., enable shield visual, disable damage, etc.)
        EnableShield(true);

        while (shieldTime > 0)
        {
            shieldTime -= Time.deltaTime;
            yield return null;
        }

        // Deactivate the shield after the time is up
        EnableShield(false);
        isShieldActive = false;
    }

    private void EnableShield(bool enable)
    {
        // Enable or disable the shield sprite
        if (shieldSprite != null)
        {
          
            shieldSprite.SetActive(enable);
        }
    }
}