using System.Collections.Generic;

using Goetia.Items;
using Goetia.Skills;
using Goetia.CharacterDetails;

namespace Goetia.Persons
{
    public class Player : Person
    {
        private int PlayerCurrentLevel { get; set; }
        private int PlayerCurrentExperience { get; set; }
        private Profession PlayerProfession { get; set; }
        private int PlayerNativeDamage { get; set; }
        //Health
        private int PlayerHealthPointsCurrent { get; set; }
        private int PlayerHealthPointsTotal { get; set; }
        //Mana
        private int PlayerManaPointsCurrent { get; set; }
        private int PlayerManaPointsTotal { get; set; }
        //Equipment
        private Dictionary<string, IWearable> PlayerEquipment { get; set; }
        //Inventory
        private List<Item> PlayerInventory { get; set; }
        //Skills
        private List<Skill> PlayerSkills { get; set; }

        public Player(int id, string name) : base(id, name)
        {
            PlayerCurrentLevel = 1;
            PlayerCurrentExperience = 0;

            PlayerProfession = new Profession();

            PlayerNativeDamage = PlayerAttributes.GetNativeDamage(PlayerCurrentLevel, PlayerProfession);

            //Amount of Players Health and Mana points depends on profession and current level
            PlayerHealthPointsTotal = PlayerAttributes.GetMaxHPAmount(PlayerCurrentLevel, PlayerProfession);
            PlayerHealthPointsCurrent = PlayerHealthPointsTotal;

            PlayerManaPointsTotal = PlayerAttributes.GetMaxMPAmount(PlayerCurrentLevel, PlayerProfession);
            PlayerManaPointsCurrent = PlayerManaPointsTotal;

            PlayerEquipment = new Dictionary<string, IWearable>();
            PlayerInventory = new List<Item>();

            PlayerSkills = new List<Skill>();
        }

        public void EquipItem(IWearable item)
        {

            var slot = item.Slot;

            if (!PlayerEquipment.ContainsKey(slot))
            {
                this.PlayerEquipment.Add(slot, item);
            }
            else
            {
                this.PlayerEquipment[slot] = item;
            }
        }


        //This method must be refactored after implementation of Item.Weight and Inventory.MaxSize properties
        public void PickUpItem(Item item)
        {
            this.PlayerInventory.Add(item);
        }

        public List<Item> GetInventory()
        {
            return PlayerInventory;
        }
        //Calculating  total damage of equipped items
        public int EquipmentDamage()
        {
            var damage = 0;

            foreach (var item in PlayerEquipment)
            {
                IWeapon weaponDamage;
                if (item.Value is IWeapon)
                {
                    weaponDamage = (IWeapon)item.Value;
                    damage += weaponDamage.GetDamageAmount();
                }
            }
            return damage;
        }

        public int TotalDamage() => this.EquipmentDamage() + this.PlayerNativeDamage;

        public void Attack()
        {
            //do smth
        }

        public void PlayerLevelUp()
        {
            this.PlayerCurrentLevel++;
        }
    }
}