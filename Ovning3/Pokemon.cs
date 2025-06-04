using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal abstract class Pokemon
    {
        protected string _name; //ska dessa vara private eller protected när det finns en get-set under?
        protected int _level;
        protected ElementType Type { get; set; } //eller ska det vara public? är ju ändå en get/set. ska väl inte gå att sätta efteråt dock? 
        protected List<Attack> Attacks { get; set; } //should be passed in and set via the constructor. This list will represent the attacks that a Pokémon knows

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length >=2 && value.Length <= 15)
                {
                    _name = value;
                }
                else
                {
                    _name = "Unknown";
                    throw new ArgumentException("Name must be between 2 and 15 characters long."); // todo oklart om kasta exception
                }
            }
        }
        public int Level
        {
            get => _level;
            set
            {
                if (value >= 1)
                {
                    _level = value;
                }
                else
                {
                    _level = 1;
                    throw new ArgumentOutOfRangeException("Level must be between 1 and 100."); // todo oklart om kasta exception
                }
            }
        }

        protected Pokemon(string name, int level, ElementType type, List<Attack> attacks) //TOdo. lägga till de andra fälten utöver attacks?
        {
            Name = name;
            Level = level;
            Type = type;
            Attacks = new List<Attack>(attacks); //TOdo ska den initialiseras här eller i egenskapen?
        }


        public void RandomAttack()
        {
            // Picks a random attack from the list of attacks and invokes its .Use-method.
            int randomAttack = new Random().Next(Attacks.Count); //börjar den på 0? 
            Attacks[randomAttack].Use(Level);

        }

        public void Attack()
        {
            // Todo Man får  välja attack själv här, men inte via metodanrop?? Lets the user pick an attack from the list of attacks and invoke its .Use-method.

            Console.WriteLine("Choose an attack by typing its number:; ");
            for (int i = 0; i < Attacks.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {Attacks[i].Name}"); //(Type: {Attacks[i].Type}, Power: {Attacks[i].BasePower})
            }

            int choice = int.Parse(Console.ReadLine()) - 1;  //ändra så det inte kan krascha om det ej är int. Och se om mitt -1 funkar

            Attacks[choice].Use(Level);
        }

        public void RaiseLevel()
        {
            // That should increment the level of the given pokemon and print that the pokemon has leveled up.
            Level++;
            Console.WriteLine($"{Name} has leveled up! New level is {Level}");
        }


    }
}
