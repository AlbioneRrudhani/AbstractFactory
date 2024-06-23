using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories.Interfaces
{
    /// <summary>
    /// AbstractFactory
    /// </summary>
    public interface ISmartGardenFactory
    {
        IIrrigationControl CreateIrrigationControl();
        ILightingControl CreateLightingControl();
    }
}
