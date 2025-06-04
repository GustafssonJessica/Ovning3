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
    //TOdo skriv till lärare gärna tar feedback på inkapslingen. Hej! Jag tar gärna emot feedback
    //på inkapslingen med åtkomstmodifierare och get/set-metoder i koden. Tycker att det var lite klurigt hur
    //jag skulle tänka kring! Har skrivit med mina tankar som kommentarer på vissa, för att visa hur jag resonerat
    internal abstract class Pokemon
    {
        private string _name = string.Empty;  //string.empty för att släcka varningen
        private int _level; //_name och _level privata, så att subklasserna tvingas gå genom get/set för att ändra värdet
        public ElementType Type { get; } //Readonly då det inte ska behöva ändras elementtyp efter initialisering
        public List<Attack> Attacks { get; } //Här skapas endast variabeln

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
            Attacks = attacks; //här tilldelas variabeln i fältet Attacks en referens till listan som skickas in i konstruktorn
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

            bool validNumber = int.TryParse(Console.ReadLine(), out int choice); //ToDo flytta till egen metod för validering?
            //todo ändra så att det inte krashar om slänger in fel nummer

            if (validNumber)
            {
                int placeInList = choice - 1;
                if (placeInList <= Attacks.Count)
                {
                    Attacks[choice-1].Use(Level); //-1 för att användaren ska kunna välja attack 1 som index 0 i listan
                }
                else
                {
                    Console.WriteLine("Invalid choice. No attack performed.");
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
