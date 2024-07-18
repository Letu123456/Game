using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{

    public AudioSource gunshot;
    public AudioSource lootItem;

    private bool canPlaySound = true;
    private float cooldownTime = 0.1f;

    void Start()
    {
        
    }

    public void playGunShot()
    {
        if (canPlaySound)
        {
            gunshot.Play();
            StartCoroutine(SoundCooldown());
        }
        
    }

    private IEnumerator SoundCooldown()
    {
        canPlaySound = false;
        yield return new WaitForSeconds(cooldownTime);
        canPlaySound = true;
    }

    public void playLootItem()
    {
        lootItem.Play();
    }

    void Update()
    {
        
    }
}
