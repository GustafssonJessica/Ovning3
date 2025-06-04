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


    /*
  
F: When you create a Pokémon and try to access its fields directly – does it work? Why or why not?
        A: Nej det går inte, för fälten är protected (inte public), vilket gör att bara klassen och subklasserna kan komma åt dem.
F: If you later want to add a new property that applies to all Electric-type Pokémon, where should you place it to avoid repetition?
        A: I ElectricPokemon-klassen, då kommer alla pokemon som är elektriska att ärva den egenskapen.
F: If instead the new property should apply to all Pokémon, where would be the correct place to define it?
        A: I den abstrakta Pokemon-klassen!
F: What happens if you try to add a Charmander to a list that only allows WaterPokemon?
        A: Jag får ett kompileringsfel som säger att det inte går att konvertera den från en charmander till vattenpokemon
F: You want to store different types of Pokémon – Charmander, Squirtle, and Pikachu – in the same list. What type should the list have for that to work?
        A: En List<Pokemon> eftersom alla dessa är pokemon som ärver från Pokemon-klassen.
F: When you loop through the list and call Attack(), what ensures that the correct attack behavior is executed for each Pokémon?
        A: För att när vi anropar Attack() så används attacker som är medskickade via konstruktorn, så de är redan medskickade när vi skapar pokemonen. 
F: If you create a method that only exists on Pikachu, why can’t you call it directly when it’s stored in a List<Pokemon>? How could you still access it?
        A: För att listan bara har typer av pokemon, och i pokemon-klassen finns inte den metoden. FÖr att komma åt den måste man casta om den till en pikachu
     * */

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

            List<Pokemon> pokemons = new List<Pokemon>(); //todo bestäm om ha var under
            var charmander1 = new Charmander("Charmander", 5, new List<Attack> { flamethrower, ember });
            var charmander2 = new Charmander("Charmander2", 10, new List<Attack> { flamethrower, ember });
            var squirtle1 = new Squirtle("Squirtle", 7, new List<Attack> { waterGun, bubble });
            var squirtle2 = new Squirtle("Squirtle2", 14, new List<Attack> { waterGun, bubble });
            var pikachu1 = new Pikachu("Pikachu", 3, new List<Attack> { thunderbolt, spark });
            var pikachu2 = new Pikachu("Pikachu2", 20, new List<Attack> { thunderbolt, spark });

            pokemons.Add(charmander1); //TOdo ändra till en bättre lösning addera pokemons
            pokemons.Add(charmander2);
            pokemons.Add(squirtle1);
            pokemons.Add(squirtle2);
            pokemons.Add(pikachu1);
            pokemons.Add(pikachu2);

            //TOdo - kolla i subklasserna huruvida override bör användas någonstans, ex med attackerna. sök ledtråd i frågan över om attacker
 
            foreach (var pokemon in pokemons) //behöver de vara pokemons explicit eller ok om de är subklasser? se video working with polymorphims
            {
                pokemon.RaiseLevel();
                pokemon.Attack();
                //behöver man casta här när den är lagrad i grunden som en pikachu?
                if (pokemon is Pikachu) //Här kollar vi om pokemon är en pikachu, om så säger vi till pokemon att bete sig som det, vartefter vi anropar funktionen evolve
                { //eller behöver man casta den? 
                    Pikachu pikachu = (Pikachu)pokemon;
                    pikachu.Evolve();
                }

                Console.WriteLine(); //tom rad för att få lite mellanrum
            }


        }
    }
}


//ToDo -bestäm hur släcka varningar
