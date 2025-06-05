using System.Net.NetworkInformation;

namespace Ovning3
{
    /* REFLEKTERANDE FRÅGOR
  
F: When you create a Pokémon and try to access its fields directly – does it work? Why or why not?
        A: Nej det går inte. Fälten är privata, så de kan inte nås utifrån klassen. Name och Level kan endast påverkas genom deras
        get/set-metoder. Type och attack har endast get-metod, så om jag förstått det rätt så kan de inte ändras varseig av 
        klassen själv eller andra klasser efter att värdena satts i konstruktorn, men däremot nås via get-metoden.

F: If you later want to add a new property that applies to all Electric-type Pokémon, where should you place it to avoid repetition?
        A: I ElectricPokemon-klassen, då kommer alla pokemon som är elektriska att ärva den egenskapen.

F: If instead the new property should apply to all Pokémon, where would be the correct place to define it?
        A: I den abstrakta Pokemon-klassen!

F: What happens if you try to add a Charmander to a list that only allows WaterPokemon?
        A: Jag får ett kompileringsfel som säger att det inte går att konvertera den från en charmander till vattenpokemon

F: You want to store different types of Pokémon – Charmander, Squirtle, and Pikachu – in the same list. What type should the list have for that to work?
        A: En List<Pokemon> eftersom alla dessa är pokemon som ärver från Pokemon-klassen.

F: When you loop through the list and call Attack(), what ensures that the correct attack behavior is executed for each Pokémon?
        A: För att när vi anropar Attack() så används attackerna som är medskickade till den specifika pokemonen via konstruktorn.

F: If you create a method that only exists on Pikachu, why can’t you call it directly when it’s stored in a List<Pokemon>? How could you still access it?
        A: För att objekten i listan behandlas som pokemon (basklassen), 
          och i pokemon-klassen finns inte den metoden. För att komma åt den måste man casta pikachu-objektet till en pikachu
     * */

    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapar attacker
            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);

            var waterGun = new Attack("Water Gun", ElementType.Water, 8);
            var bubble = new Attack("Bubble", ElementType.Water, 4);

            var thunderbolt = new Attack("Thunderbolt", ElementType.Electric, 10);
            var spark = new Attack("Spark", ElementType.Electric, 5);

            // Skapar Pokémon
            var charmander1 = new Charmander("Charmander", 5, new List<Attack> { flamethrower, ember });
            var charmander2 = new Charmander("Charmander2", 10, new List<Attack> { flamethrower, ember });
            var squirtle1 = new Squirtle("Squirtle", 7, new List<Attack> { waterGun, bubble });
            var squirtle2 = new Squirtle("Squirtle2", 14, new List<Attack> { waterGun, bubble });
            var pikachu1 = new Pikachu("Pikachu", 3, new List<Attack> { thunderbolt, spark });
            var pikachu2 = new Pikachu("Pikachu2", 20, new List<Attack> { thunderbolt, spark });

            // Skapar en lista och lägger till Pokémon
            List<Pokemon> pokemons = new List<Pokemon>();
            pokemons.Add(charmander1);
            pokemons.Add(charmander2);
            pokemons.Add(squirtle1);
            pokemons.Add(squirtle2);
            pokemons.Add(pikachu1);
            pokemons.Add(pikachu2);

            // Loopar igenom listan och anropar metoder på varje Pokémon
            foreach (var pokemon in pokemons)
            {
                pokemon.RaiseLevel();
                pokemon.Attack();
                if (pokemon is Pikachu) //Kollar om pokemon är en pikachu, om så säger vi till pokemon att bete sig som det så att vi kan
                                        //anropa funktionen evolve som endast pikachu har
                {
                    Pikachu pikachu = (Pikachu)pokemon;
                    pikachu.Evolve();
                }
                Console.WriteLine(); //Tom rad för att få lite mellanrum
            }
        }
    }
}

