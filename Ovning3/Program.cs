namespace Ovning3
{
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
        }
    }
}
