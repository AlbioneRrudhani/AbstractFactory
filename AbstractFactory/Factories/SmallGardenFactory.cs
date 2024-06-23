using AbstractFactory.Products.Interfaces;
using AbstractFactory.Products;
using AbstractFactory.Factories.Interfaces;

namespace AbstractFactory.Factories
{

    /// <summary>
    ///  ConcreteFactory
    /// </summary>
    internal class SmallGardenFactory : ISmartGardenFactory
    {
        public IIrrigationControl CreateIrrigationControl() => new SmallGardenIrrigation();
        public ILightingControl CreateLightingControl() => new SmallGardenLighting();
    }
}
