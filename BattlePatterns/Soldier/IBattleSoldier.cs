using BattlePatterns.Grifon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePatterns.Soldier
{
    internal interface IBattleSoldier
    {
        public void Battle(IGrifon grifon);
    }
}