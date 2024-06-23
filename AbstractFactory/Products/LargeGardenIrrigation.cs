using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class LargeGardenIrrigation : IIrrigationControl
    {
        public void CalculateWaterUsage(int area)
        {
            double waterUsage = area * 0.75; //liters per square meter
            Console.WriteLine($"Large Garden Water Usage: {waterUsage} liters");
        }
    }
}
