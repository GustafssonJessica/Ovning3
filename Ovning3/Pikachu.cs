using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Pikachu : ElectricPokemon, IEvolvable
    {

        public string EvolveName { get; } = "Raichu"; //Raichu verkar vara slutstationen för en pikashu, så därav ingen set-funktion. oklart om get behövs med

        public Pikachu(string name, int level, List<Attack> attacks) 
            : base(name, level, attacks)
        {
        }

        public void Evolve()
        {
            Level += 10;
            Console.WriteLine($"Pikachu is evolving... Now it's {EvolveName}! Level {Level}!"); 
        }
    }
}
