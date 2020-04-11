using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Goetia.Persons;

namespace Goetia.Items
{
    public class Weapon : Item, IWearable, IWeapon
    {
        private int WeaponDamage { get; set; }
        public string WeaponType { get; set; }

        public string Slot { get; set; } = "Right Hand";

        public Weapon(int id, string name, , int weaponDamage) : base(id, name)
        {
             
            WeaponDamage = weaponDamage >= 0 ? weaponDamage : 0;
        }
        public int GetDamageAmount() => WeaponDamage;
    }
}
