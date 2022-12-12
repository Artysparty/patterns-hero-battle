using BattlePatterns.Soldier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePatterns.Grifon
{
    internal interface IBattleGrifon
    {
        public void Battle(ISoldier soldier);
    }
}
