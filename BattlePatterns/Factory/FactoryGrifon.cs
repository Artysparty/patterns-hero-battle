using BattlePatterns.Grifon;
using BattlePatterns.Soldier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePatterns.Factory
{
    internal static class FactoryGrifon
    {
        public static IGrifon CreateGrifon(string type)
        {
            if (type.Equals("Белый грифон"))
            {
                return new WhiteGrifon();
            }
            else if (type.Equals("Черный грифон"))
            {
                return new BlackGrifon();

            }
            else return null;
        }
    }
}

