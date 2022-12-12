using BattlePatterns.Grifon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePatterns.Soldier
{
    internal class WhiteSoldier : ISoldier
    {
        public int Health { get; set; }
        public int Damage { get; set; }

        public WhiteSoldier()
        {
            Health = 100;
            Damage = 10;
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

        public void Battle(IGrifon grifon)
        {
            grifon.Health = grifon.Health - 200;
        }
    }
}