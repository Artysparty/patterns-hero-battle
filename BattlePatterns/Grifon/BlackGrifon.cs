using BattlePatterns.Soldier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePatterns.Grifon
{
    internal class BlackGrifon : IGrifon
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int FlightSpeed { get; set; }

        public BlackGrifon()
        {
            Health = 330;
            Damage = 70;
            FlightSpeed = 50;
        }

        public void Confirmation()
        {
            Console.WriteLine("that's right");
        }

        public void Negative()
        {
            Console.WriteLine("no way");
        }

        public void Encouragement()
        {
            Console.WriteLine("excellent");
        }

        public void Battle(ISoldier soldier)
        {
            soldier.Health = soldier.Health - 70;
        }
    }
}