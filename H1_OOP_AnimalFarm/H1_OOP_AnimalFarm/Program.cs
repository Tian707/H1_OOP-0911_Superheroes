using H1_OOP_AnimalFarm.Model;

namespace H1_OOP_AnimalFarm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalStation animalStation = new AnimalStation();
            animalStation.ToString();

            // populate the animalStation
            FarmAnimal chicken1 = new Chicken(EType.Bird, ESex.Male, EReproduction.Viviparity, ELegCount.two, EAppearanceType.Feathered, 5, ESpecie.Chicken, "White");
            Console.WriteLine(chicken1.LayEggOrGiveBirth());
            Console.WriteLine(chicken1.ToString());
            Console.WriteLine();

            FarmAnimal chicken2 = new Chicken(EType.Bird, ESex.Female, EReproduction.Viviparity, ELegCount.two, EAppearanceType.Feathered, 14, ESpecie.Chicken, "Brown");
            Console.WriteLine(chicken2.LayEggOrGiveBirth());

            FarmAnimal rabbit1 = new Rabbit(EType.Mammal, ESex.Female, EReproduction.Oviparity, ELegCount.four, EAppearanceType.ShortHaired, 4, ESpecie.Rabbit, "White");
            Animal rabbit2 = new Rabbit(EType.Mammal, ESex.Male, EReproduction.Oviparity, ELegCount.four, EAppearanceType.LongHaired, 4, ESpecie.Rabbit, "Grey");
            Console.WriteLine(rabbit2.LayEggOrGiveBirth());

            Dog dog1 = new Dog(EType.Mammal, ESex.Male, EReproduction.Oviparity, ELegCount.four, EAppearanceType.LongHaired, 5, ESpecie.Dog, "Black");
            Animal dog2 = new Dog(EType.Mammal, ESex.Female, EReproduction.Oviparity, ELegCount.four, EAppearanceType.ShortHaired, 6, ESpecie.Dog, "Yellow");
            FarmAnimal dog3 = new Dog(EType.Mammal, ESex.Female, EReproduction.Oviparity, ELegCount.four, EAppearanceType.ShortHaired, 8, ESpecie.Dog, "White");



            Console.WriteLine(animalStation.AddAnimal(chicken1));
            Console.WriteLine(animalStation.AddAnimal(chicken2));
            Console.WriteLine(animalStation.AddAnimal(rabbit1));
            Console.WriteLine(animalStation.AddAnimal((FarmAnimal)rabbit2));
            Console.WriteLine(animalStation.AddAnimal(dog1));
            Console.WriteLine(animalStation.AddAnimal((FarmAnimal)dog2));
            Console.WriteLine(animalStation.AddAnimal(dog3));
            Console.WriteLine("Print all animal in the station now:");
            Console.WriteLine(animalStation.ToString(animalStation.FarmAnimals));

            Console.WriteLine("Remove animals from the station:");
            Console.WriteLine(animalStation.DeleteAnimal((FarmAnimal)dog2));
            Console.WriteLine(animalStation.DeleteAnimal(chicken1));
            Console.WriteLine(animalStation.DeleteAnimal((FarmAnimal)rabbit2));

            cw
        }
    }
}