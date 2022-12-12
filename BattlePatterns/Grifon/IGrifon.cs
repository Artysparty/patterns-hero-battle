using BattlePatterns.Soldier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePatterns.Grifon
{
    internal interface IGrifon : IFly, ICommands, IBattleGrifon
    {
        public int Health { get; set; }
        public int Damage { get; set; }
    }
}

