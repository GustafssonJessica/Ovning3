using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Pikachu : ElectricPokemon, IEvolvable
    {

        public string EvolveName { get; } = "Raichu"; // Raichu verkar vara slutstationen för en pikashu, så därav ingen set

        public Pikachu(string name, int level, List<Attack> attacks, ElementType type = ElementType.Electric) : base(name, level, attacks, type)
        {
        }

        public void Evolve()
        {
            throw new NotImplementedException();
            Level += 10;
            Console.WriteLine($"Pikachu is evolving... Now it's Raichu! Level {Level}!"); //ToDo ändra så itne rachu är hårdkodat
        }
    }
}
