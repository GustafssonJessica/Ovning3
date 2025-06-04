using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class FirePokemon : Pokemon
    {


        public FirePokemon(string name, int level, List<Attack> attacks, ElementType type = ElementType.Fire) : base(name, level, type, attacks) 
        {
        }
    }
}
