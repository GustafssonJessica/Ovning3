using System.Net.NetworkInformation;

namespace Ovning3
{

    /*
    Encapsulation(fields + validation)
    Inheritance and abstraction
    Polymorphism
    Interface implementation
    Using enums and working with composition
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);

            var waterGun = new Attack("Water Gun", ElementType.Water, 8);
            var bubble = new Attack("Bubble", ElementType.Water, 4);

            var thunderbolt = new Attack("Thunderbolt", ElementType.Electric, 10);
            var spark = new Attack("Spark", ElementType.Electric, 5);

            List<Pokemon> pokemons = new List<Pokemon>();
            Pokemon charmander1 = new Charmander("Charmander", 5, new List<Attack> { flamethrower, ember });
            Pokemon charmander2 = new Charmander("Charmander2", 5, new List<Attack> { flamethrower, ember });
            Pokemon squirtle1 = new WaterPokemon("Squirtle", 5, new List<Attack> { waterGun, bubble });
            Pokemon squirtle2 = new WaterPokemon("Squirtle2", 5, new List<Attack> { waterGun, bubble });
            Pokemon pikachu1 = new Pikachu("Pikachu", 5, new List<Attack> { thunderbolt, spark });
            Pokemon pikachu2 = new Pikachu("Pikachu2", 5, new List<Attack> { thunderbolt, spark });

            pokemons.Add(charmander1); //ämdra till en bättre lösning addera pokemons
            pokemons.Add(charmander2);
            pokemons.Add(squirtle1);
            pokemons.Add(squirtle2);
            pokemons.Add(pikachu1);
            pokemons.Add(pikachu2);

            foreach (var pokemon in pokemons)
            {
               pokemon.RaiseLevel();
                pokemon.RandomAttack();

                //ToDO kör cast-grejen här med IEvolvable

            }


        }
    }
}


//ToDo -bestäm hur släcka varningar
