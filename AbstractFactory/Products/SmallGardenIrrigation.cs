using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class SmallGardenIrrigation : IIrrigationControl
    {

        public void CalculateWaterUsage(int area)
        {
            double waterUsage = area * 0.5; //liters per square meter
            Console.WriteLine($"Small Garden Water Usage: {waterUsage} liters");
        }
    }
}
