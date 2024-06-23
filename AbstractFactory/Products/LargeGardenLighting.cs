using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class LargeGardenLighting : ILightingControl
    {
        public bool IsLightingEnabled => true;
    }
}
