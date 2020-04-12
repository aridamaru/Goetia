using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Goetia.Items;
using Goetia.Persons;
using Goetia.Skills;

namespace Goetia.GameProcess
{
    public class Game
    {
        //Game session identifier
        public int GameId { get; set; }

        //Available weapons in current game
        public List<IWearable> Arsenal { get; set; }

        //Available skills in current game
        public List<Skill> SkillBox { get; set; }
        
        //List of players participating in current game
        public List<Player> Players { get; set; }

        public Game(int id)
        {
            GameId = id;
            Arsenal = new List<IWearable>();
            SkillBox = new List<Skill>();
            Players = new List<Player>();

        }

        public void InitializeEnvironment(List<IWearable> arsenal, List<Skill> skillBox)
        {
            Arsenal = arsenal;
            SkillBox = skillBox;
        }

        /// <summary>
        /// Should be optimized
        /// </summary>
        public void CreatePlayers()
        {
            Console.WriteLine("First player - introduce yorself!");
            Console.WriteLine("What is your name first player?");
            Players.Add(new Player(1, Console.ReadLine()));

            Console.WriteLine("\n\nFine.Let's continue introduction process..");
            Console.WriteLine("What is your name second player?");
            Players.Add(new Player(2, Console.ReadLine()));
        }
        public void ChooseWeapon()
        {
            foreach (var player in Players)
            {
                Console.WriteLine("\nOk.{0} choose your weapon from list.. ", player.Name);
                Console.WriteLine("Id : Name");
                foreach (var weapon in Arsenal)
                {
                    Console.WriteLine("{0}  : {1}", weapon.Id, weapon.Name);
                }
                Console.WriteLine("Enter Id..");

                var chosenItem = Int32.Parse(Console.ReadLine());
                player.PickUpItem((Item)Arsenal.Where(o => o.Id == chosenItem).FirstOrDefault());
                player.EquipItem((IWearable)player.GetInventory().Where(o => o.Id == chosenItem).FirstOrDefault());
            }
        }

        public void Run()
        {
            ///InitilizeEnvironment() & CreatePlayers() should placed here
            ///
            ///
            Console.WriteLine("Welcome to Goetia!");
            ///
            ///
            
        }
    }
}
