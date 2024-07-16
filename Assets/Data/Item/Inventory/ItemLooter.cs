using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;


[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(Rigidbody))]
public class ItemLooter : AllBeh
{
    [SerializeField] protected Inventory inventory;
    [SerializeField] protected SphereCollider _collider;
    [SerializeField] protected Rigidbody _rigidbody;
    [SerializeField] TextMeshProUGUI pointUI;
    private Shield shield;
    ShipHPSlide shipHPSlide;

    int point = 0;

    PlaySounds sounds;
   
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadInventory();
        this.LoadTrigger();
        this.LoadRigidbody();
    }

    protected override void Start()
    {
        shield = GetComponent<Shield>();
        shipHPSlide = FindAnyObjectByType<ShipHPSlide>();
        sounds = FindAnyObjectByType<PlaySounds>();
    }
    protected virtual void LoadInventory()
    {
        if (this.inventory != null) return;
        this.inventory = transform.parent.GetComponent<Inventory>();
        Debug.LogWarning(transform.name + " LoadInventory", gameObject);
    }

    protected virtual void LoadTrigger()
    {
        if (this._collider != null) return;
        this._collider = transform.GetComponent<SphereCollider>();
        this._collider.isTrigger = true;
        this._collider.radius = 0.3f;
        Debug.LogWarning(transform.name + " LoadTrigger", gameObject);
    }

    protected virtual void LoadRigidbody()
    {
        if (this._rigidbody != null) return;
        this._rigidbody = transform.GetComponent<Rigidbody>();
        this._rigidbody.useGravity = false;
        this._rigidbody.isKinematic = true;
        Debug.LogWarning(transform.name + " LoadRigidbody", gameObject);
    }

    protected virtual void OnTriggerEnter(Collider collider)
    {

        ItemPickupable itemPickupable = collider.GetComponent<ItemPickupable>();
        if (itemPickupable == null) return;

        ItemCode itemCode = itemPickupable.GetItemCode();
        if (this.inventory.AddItem(itemCode, 1))
        {
            itemPickupable.Picked();
            point++;
            sounds.playLootItem();
            if(itemCode.ToString() == "chickenFoot")
            {
                
                shipHPSlide.setAddHP(5);
            }else if (itemCode.ToString() == "gold")
            {
                point++;
            }
            else
            {
                
                shield.ActivateShield();
            }
            pointUI.text = "Score:" + point.ToString();

        }
    }
}