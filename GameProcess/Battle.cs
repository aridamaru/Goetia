using System;
using System.Collections.Generic;
using System.Linq;

using Goetia.Persons;

namespace Goetia.GameProcess
{
    public class Battle
    {
        private string _winnerName { get; set; } 
        private bool IsWinnerExist { get; set; } = false;
        private List<Player> _participatingPlayers { get; set; }
        public Battle(List<Player> players)
        {
            _participatingPlayers = players;
        }

        public void StartBattle()
        {
            List<int> damageList = new List<int>();
            foreach (var player in _participatingPlayers)
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
                _winnerName = _participatingPlayers.Where(o => o.TotalDamage() == damageList.Max())
                                                   .Select(o => o.Name).First();
            }
        }
        public void ShowWinner()
        {
            if (IsWinnerExist)
            {
                Console.WriteLine("Winner is {0}! Congratulations!", _winnerName);
            }
            else
            { 
                Console.WriteLine("Winner is not determined yet!");
            }
        }
    }
}
