using BattlePatterns.Grifon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePatterns.Soldier
{
    internal class BlackSoldier : ISoldier
    {
        public int Health { get; set; }
        public int Damage { get; set; }

        public BlackSoldier()
        {
            Health = 90;
            Damage = 15;
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

        public void Battle(IGrifon grifon)
        {
            grifon.Health = grifon.Health - 217;
        }
    }
}