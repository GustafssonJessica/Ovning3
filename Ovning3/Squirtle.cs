using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Squirtle : WaterPokemon
    {
        public Squirtle(string name, int level, List<Attack> attacks) 
            : base(name, level, attacks)
        {
        }
    }
}
