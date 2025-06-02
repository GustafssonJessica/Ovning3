using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Attack
    {
        public string Name { get; set; }

        public ElementType Type { get; set; }

        public int BasePower { get; set; }


        public Attack(string name, ElementType type, int basePower)
        {
            Name = name;
            Type = type;
            BasePower = basePower;
        }



        public void Use(int level)
        {
            Console.WriteLine($"{Name} hits with a power of {BasePower}"); //basepwer + level ska det vara
        }
    }


}
