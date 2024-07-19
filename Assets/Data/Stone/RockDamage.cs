using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Data.Stone
{
    public class RockDamage : MonoBehaviour
    {
        public int damage = 10;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            ShipCtrl ship = collision.gameObject.GetComponent<ShipCtrl>();
            if (ship != null)
            {
                ship.TakeDamage(damage);
            }
        }
    }
}
