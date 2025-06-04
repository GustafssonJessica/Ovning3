using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    //TOdo släck varningar + skriv till lärare gärna tar feedback på inkapslingen
    internal abstract class Pokemon
    {
        private string _name; //privata så att subklasserna tvingas gå genom get/set för att ändra värdet
        private int _level;
        public ElementType Type { get; } //gör readonly då det inte ska behöva ändras elementtyp efter initialisering
        public List<Attack> Attacks { get; } // TODO förstod det som att set inte behövs för att lägga till attacker efteråt, prova det

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
                }
            }
        }

        protected Pokemon(string name, int level, ElementType type, List<Attack> attacks)
        {
            Name = name;
            Level = level;
            Type = type;
            Attacks = attacks;
        }


        public void RandomAttack()
        {
            // Väljer en slumpmässig attack från listan av attacker och anropar dess .Use-metod.
            int randomAttack = new Random().Next(Attacks.Count);
            Attacks[randomAttack].Use(Level);
        }

        public void Attack()
        {
            //Låter användaren välja en attack från listan av attacker och anropar dess .Use-metod.

            Console.WriteLine("Choose an attack by typing its number:; ");
            for (int i = 0; i < Attacks.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {Attacks[i].Name}");
            }

            int choice = int.Parse(Console.ReadLine()) - 1;  //Todo ändra så det inte kan krascha om det ej är int. Ex skriv bara ingen attack utfördes pga ogiltig inmatning

            Attacks[choice].Use(Level);
        }

        public void RaiseLevel()
        {
            // Ökar nivån på den angivna pokémonen och skriva ut att pokémonen har gått upp i nivå.
            Level++;
            Console.WriteLine($"{Name} has leveled up! New level is {Level}");
        }
    }
}
