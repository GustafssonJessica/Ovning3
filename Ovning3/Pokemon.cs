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
    internal abstract class Pokemon
    {
        private string _name = string.Empty;  //string.empty för att släcka varningen
        private int _level; //_name och _level privata, så att subklasserna tvingas gå genom get/set för att ändra värdet
        public ElementType Type { get; } //Readonly då det inte (enligt mitt vetande) ska behöva ändras elementtyp efter initialisering. 
                                         //Har jag förstått rätt så innebär detta att inte en klassen själv kan ändra värdet senare?
        public List<Attack> Attacks { get; } //Här skapas endast egenskapen, men inte själva objektet.
                                             //Endast get för att man inte ska kunna byta själva listan efter initialisering
                                             //(förstått det som att man kan det annars iallafall, men nu bara kan förändra innehållet)

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length >=2 && value.Length <= 15)
                    _name = value;
                else
                {
                    //Matar användaren in ett namn med <2 eller >15 karaktärer sätts det till unknown och användaren får ett meddelande om det
                    _name = "Unknown";
                    Console.WriteLine("The name has to be between 2 and 15 characters. If you entered a name that was too short or too long, it has been set to 'Unknown'.");
                }
            }
        }

        public int Level
        {
            get => _level;
            set
            {
                if (value >= 1)
                    _level = value;
                else
                {
                    //Level ska vara minst 1, skickar användaren in ett mindre värde sätts det automatiskt till 1
                    _level = 1;
                    Console.WriteLine("The level must be at least 1. If you entered a lower value, it has been set to 1.");
                }
            }
        }

        protected Pokemon(string name, int level, ElementType type, List<Attack> attacks)
        {
            Name = name;
            Level = level;
            Type = type;
            Attacks = attacks; //Här tilldelas egenskapen Attacks en referens till listan som skickas in i konstruktorn
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

            bool validNumber = int.TryParse(Console.ReadLine(), out int choice); //Validerar att användaren skriver in ett nummer

            if (validNumber)
            {
                int placeInList = choice - 1;
                if (placeInList < Attacks.Count && placeInList >= 0) //Säkerställer att användaren väljer ett nummer som finns med på listan över attacker
                {
                    Attacks[choice-1].Use(Level); //-1 för att användaren ska kunna välja attack 1 som index 0 i listan
                }
                else
                {
                    Console.WriteLine("Invalid number selected. No attack performed.");
                }
            }
            else
            {
                Console.WriteLine("No attack performed due to invalid input.");
            }
        }

        public void RaiseLevel()
        {
            // Ökar nivån på den angivna pokémonen och skriver ut att pokémonen har gått upp i nivå.
            Level++;
            Console.WriteLine($"{Name} has leveled up! New level is {Level}");
        }
    }
}
