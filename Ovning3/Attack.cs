using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Attack
    {
        public string Name { get; } //Bedömer att det ej bör finnas behov att ändra egenskaper på attack efter initialisering, därav readonly
        public ElementType Type { get; }
        public int BasePower { get; }

        public Attack(string name, ElementType type, int basePower)
        {
            Name = name;
            Type = type;
            BasePower = basePower;
        }

        public void Use(int level)
        {
            Console.WriteLine($"{Name} hits with a power of {BasePower + level}");
        }
    }
}
