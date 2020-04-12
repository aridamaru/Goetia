using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Goetia.Persons;

namespace Goetia.Items
{
    public class Weapon : Item, IWeapon
    {
        public string WeaponType { get; set; }
        private int WeaponDamage { get; set; }
        //Contains information about "Used Hands - WeaponType" dependence
        private Dictionary<string, List<string>> HandForWeapon { get; set; } = new Dictionary<string, List<string>>();
        //
        //Must be updated. Is Temporary
        private void PopulateHandForWeapon()
        {
            HandForWeapon.Add("One Handed", new List<string>()
            {
                "Dagger",
                "One-Handed sword",
                "Staff",
                "Wand",
                "Axe"
            });
            HandForWeapon.Add("Two Handed", new List<string>()
            {
                "Katar",
                "Two-Handed sword",
                "Bow"
            });
        }

        public string Slot { get; set; } = "Right Hand";

        public Weapon(int id, string name, string type, int weaponDamage) : base(id, name)
        {
            WeaponType = type;
            WeaponDamage = weaponDamage >= 0 ? weaponDamage : 0;
            PopulateHandForWeapon();
        }
        public int GetDamageAmount() => WeaponDamage;

        //If weapon is TwoHanded return true
        public bool IsTwoHanded() => HandForWeapon.Where(d => d.Value.Contains(WeaponType))
                                                  .Select(d => d.Key).First() == "Two Handed" ? true : false;

    }
}
///check if in inventory
///check if weapon equipped
///
///
///
///