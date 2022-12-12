using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePatterns
{
    internal interface ICommands
    {
        public void Confirmation();
        public void Negative();
        public void Encouragement();
    }
}