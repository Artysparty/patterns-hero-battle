using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePatterns.Soldier
{
    internal interface ISoldier : ICommands, IBattleSoldier
    {
        public int Health { get; set; }
        public int Damage { get; set; }

    }
}