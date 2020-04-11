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
        public string WeaponType { get; set; }
        private int WeaponDamage { get; set; }



        public string Slot { get; set; } = "Right Hand";

        public Weapon(int id, string name, string type, int weaponDamage) : base(id, name)
        {
            WeaponType = type;
            WeaponDamage = weaponDamage >= 0 ? weaponDamage : 0;
        }
        public int GetDamageAmount() => WeaponDamage;
    }
}
