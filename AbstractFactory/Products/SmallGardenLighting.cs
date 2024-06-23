using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class SmallGardenLighting : ILightingControl
    {
        public bool IsLightingEnabled => true;
    }
}
