using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal abstract class Pokemon
    {
        protected string _name;
        protected int _level;
        protected ElementType Type { get; set; }
        protected List<Attack> Attacks { get; set; } //should be passed in and set via the constructor. This list will represent the attacks that a Pokémon knows

        public void RandomAttack()
        {
            // Picks a random attack from the list of attacks and invokes its .Use-method.
        }

        public void Attack()
        {
            // Lets the user pick an attack from the list of attacks and invoke its .Use-method.
        }

        public void RaiseLevel()
        {
            // That should increment the level of the given pokemon and print that the pokemon has leveled up.
        }


    }
}
