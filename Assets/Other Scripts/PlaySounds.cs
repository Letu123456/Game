using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{

    public AudioSource gunshot;
    public AudioSource lootItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void playGunShot()
    {
        gunshot.Play();
    }

    public void playLootItem()
    {
        lootItem.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
