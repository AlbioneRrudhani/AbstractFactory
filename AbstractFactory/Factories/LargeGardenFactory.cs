using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products;
using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories
{
    /// <summary>
    ///  ConcreteFactory
    /// </summary>
    internal class LargeGardenFactory : ISmartGardenFactory
    {
        public IIrrigationControl CreateIrrigationControl() => new LargeGardenIrrigation();
        public ILightingControl CreateLightingControl() => new LargeGardenLighting();
    }

}
