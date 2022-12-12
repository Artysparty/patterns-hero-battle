using BattlePatterns.Soldier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePatterns.Factory
{
    internal static class FactorySoldier
    {
        public static ISoldier CreateSoldier(string type)
        {
            if (type.Equals("Белый рыцарь"))
            {
                return new WhiteSoldier();
            }
            else if (type.Equals("Черный рыцарь"))
            {
                return new BlackSoldier();

            }
            else return null;
        }
    }
}