using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class ElectricPokemon : Pokemon
    {
        public ElectricPokemon(string name, int level, List<Attack> attacks)
            : base(name, level, ElementType.Electric, attacks) // ToDo rätt sätt att skicka med elementType?
        {
        }
    }
}
