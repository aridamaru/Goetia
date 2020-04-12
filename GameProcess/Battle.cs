using System;
using System.Collections.Generic;
using System.Linq;

using Goetia.Persons;

namespace Goetia.GameProcess
{
    public class Battle
    {
        private string WinnerName { get; set; } 
        private bool IsWinnerExist { get; set; } = false;
        private List<Player> ParticipatingPlayers { get; set; }
        public Battle(List<Player> players)
        {
            ParticipatingPlayers = players;
        }

        public void StartBattle()
        {
            List<int> damageList = new List<int>();
            foreach (var player in ParticipatingPlayers)
            {
                damageList.Add(player.TotalDamage());
            }
            if (damageList.Where(o => o == damageList.Max()).Count() != 1)
            {
                IsWinnerExist = false;
            }
            else
            {
                IsWinnerExist = true;
                WinnerName = ParticipatingPlayers.Where(o => o.TotalDamage() == damageList.Max())
                                                   .Select(o => o.Name).First();
            }
        }
        public void ShowWinner()
        {
            if (IsWinnerExist)
            {
                Console.WriteLine("Winner is {0}! Congratulations!", WinnerName);
            }
            else
            { 
                Console.WriteLine("Winner is not determined yet!");
            }
        }
    }
}
