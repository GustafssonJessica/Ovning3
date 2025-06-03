using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class WaterPokemon : Pokemon
    {
        public WaterPokemon(string name, int level, List<Attack> attacks, ElementType type = ElementType.Water) : base(name, level, type, attacks) // ToDo - skicka med saker till basklassen??
        {
        }

    }
}
