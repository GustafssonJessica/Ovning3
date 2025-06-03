using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class ElectricPokemon : Pokemon
    {

        public ElectricPokemon(string name, int level, List<Attack> attacks, ElementType type = ElementType.Electric) : base(name, level, type, attacks) // ToDo nått med base här?
        {
        }
    }
}
