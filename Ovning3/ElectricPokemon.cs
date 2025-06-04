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
            : base(name, level, ElementType.Electric, attacks) //I samtliga subklasser skickas elementtypen med in i baskonstruktorn
        {
        }
    }
}
