using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Goetia.Persons;
using Goetia.GameProcess;
using Goetia.Items;
using Goetia.Skills;
using Goetia.CharacterDetails;


namespace Goetia
{
    class Program
    {
        static void Main(string[] args)
        {
            //arsenal & skillBox data should be taken from DbContext
            var arsenal = new List<IWearable>()
                    {
                        new Weapon(1, "Jamadhar","Katar", 110),
                        new Weapon(2, "Gladius", "Dagger", 120),
                        new Weapon(3, "Flamberg","One-Handed sword", 130) ,
                        new Weapon(4, "ZweiHander","Two-Handed sword", 140)
                    };
            var skillBox = new List<Skill>()
                    {
                        new PhysicalSkill(1, "Bash", 100),
                        new PhysicalSkill(2, "Assault", 110),
                        new PhysicalSkill(3, "Grimtooth", 90)
                    };
            
            //Initialize new Game instance with 'int' identifier as parameter
            var game = new Game(1);

            game.Run();
            game.InitializeEnvironment(arsenal, skillBox);
            game.CreatePlayers();
            game.ChooseWeapon();

            //Initialize new Battle instance with 'List<Player>' as parameter
            var battle = new Battle(game.Players);

            battle.StartBattle();
            battle.ShowWinner();

            Console.ReadKey();
        }
    }
}
