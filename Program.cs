using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Goetia.Persons;
using Goetia.BattleProcess;
using Goetia.Items;
using Goetia.Skills;
using Goetia.CharacterDetails;


namespace Goetia
{
    class Program
    {
        static void Main(string[] args)
        {
            var arsenal = new List<Weapon>() 
            {
                new Weapon(1, "Jamadhar", 110),
                new Weapon(2, "Gladius", 120),
                new Weapon(3, "Flamberg", 130) ,
                new Weapon(4, "ZweiHander", 140) 
            };

            var firstSkill = new PhysicalSkill(1, "Bash", 100);
            var secondSKill = new PhysicalSkill(2, "Assault", 110);

            Console.WriteLine("Welcome to Goetia!");

            //Players Introduction
            Console.WriteLine("First player - introduce yorself!");
            Console.WriteLine("What is your name first player?");
            var firstPlayer = new Player(1, Console.ReadLine());

            Console.WriteLine("Fine.Let's continue introduction process..");
            Console.WriteLine("What is your name second player?");
            var secondPlayer = new Player(2, Console.ReadLine());

            Console.WriteLine("Ok.{0} choose your weapon from list..", firstPlayer.Name);
            Console.WriteLine("Id : Name");
            foreach(var weapon in arsenal)
            {
                Console.WriteLine("{0}  : {1}", weapon.Id, weapon.Name);
            }

            Console.WriteLine("Enter Id...");
            var chosenItemFirst = Int32.Parse(Console.ReadLine());
            firstPlayer.EquipItem(arsenal.Where(o => o.Id == chosenItemFirst).FirstOrDefault());

            Console.WriteLine("Now it's your turn {0}! Choose your weapon from list..", secondPlayer.Name);
            Console.WriteLine("Id : Name");
            foreach (var weapon in arsenal)
            {
                Console.WriteLine("{0}  : {1}", weapon.Id, weapon.Name);
            }
            Console.WriteLine("Enter Id..");
            var chosenItemSecond = Int32.Parse(Console.ReadLine());
            secondPlayer.EquipItem(arsenal.Where(o => o.Id == chosenItemSecond).FirstOrDefault());

            Console.WriteLine("Fine. Are you ready for Battle?");
            Console.WriteLine("If so type yes");
            Console.WriteLine("{0} : Do you want to start?", firstPlayer.Name);
            var firstPlayerAprovement = Console.ReadLine();
            Console.WriteLine("{0} : Do you want to start?", secondPlayer.Name);
            var secondPlayerAprovement = Console.ReadLine();

            List<Player> battlers = new List<Player>();
            battlers.Add(firstPlayer);
            battlers.Add(secondPlayer);

            if (firstPlayerAprovement == "yes" && secondPlayerAprovement == "yes")
            {
                var gendalt = new Battle(battlers);
                gendalt.StartBattle();
                gendalt.ShowWinner();
            }

            Console.ReadKey();
        }
    }
}
