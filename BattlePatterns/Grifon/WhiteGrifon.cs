using BattlePatterns.Soldier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePatterns.Grifon
{
    internal class WhiteGrifon : IGrifon
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int FlightSpeed { get; set; }

        public WhiteGrifon()
        {
            Health = 400;
            Damage = 100;
            FlightSpeed = 40;
        }

        public void Confirmation()
        {
            Console.WriteLine("Так точно");
        }

        public void Negative()
        {
            Console.WriteLine("Никак нет");
        }

        public void Encouragement()
        {
            Console.WriteLine("Отлично");
        }

        public void Battle(ISoldier soldier)
        {
            soldier.Health = soldier.Health - 100;
        }
    }
}