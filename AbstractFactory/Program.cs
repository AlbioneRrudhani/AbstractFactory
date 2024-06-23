using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallGardenFactory = new SmallGardenFactory();
            var smallGardenService = new SmartGardenClient(smallGardenFactory, "Small Garden", 100);
            smallGardenService.DisplayServiceDetails();

            Console.WriteLine("===================================================================");

            var largeGardenFactory = new LargeGardenFactory();
            var ruralLargeGardenService = new SmartGardenClient(largeGardenFactory, "Large Garden", 200);
            ruralLargeGardenService.DisplayServiceDetails();
        }
    }
}
