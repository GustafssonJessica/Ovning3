using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class ElectricPokemon : Pokemon
    {

        public ElectricPokemon(string name, int level, List<Attack> attacks, ElementType type = ElementType.Electric) : base(name, level, type, attacks) // ToDo rätt sätt att skicka med elementType?
                                                                                                                                                                         // I Demo: adding herritance vid 4min, så kan man se att de bara skickar med
                                                                                                                                                                         //ElementType.Elextric till basklassen
                                                                                                                                                                         //och inte specificerar det som in-parameter...
                                                                                                                                                                         // ändå rimligt? det är ju självklart och ska
                                                                                                                                                                         //inte kunna ändras.
                                                                                                                                                                         // vad behäver jag då ändra i basklassen/elektriska pokemon/program?
                                                                                                                                                                         //behöver iaf inte ändras i pikachu, för den ärver ju härifrån

        {
        }
    }
}
