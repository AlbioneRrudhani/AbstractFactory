using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products.Interfaces;

namespace AbstractFactory
{
    /// <summary>
    /// Client class 
    /// </summary>
    public class SmartGardenClient
    {
        private readonly IIrrigationControl _irrigationControl;
        private readonly ILightingControl _lightingControl;
        private string _gardenType;
        private int _gardenArea;

        public SmartGardenClient(ISmartGardenFactory factory, string gardenType, int gardenArea)
        {
            _irrigationControl = factory.CreateIrrigationControl();
            _lightingControl = factory.CreateLightingControl();
            _gardenType = gardenType;
            _gardenArea = gardenArea;
        }

        public void DisplayServiceDetails()
        {
            Console.WriteLine($"Garden Type: {_gardenType}");
            _irrigationControl.CalculateWaterUsage(_gardenArea);
            Console.WriteLine($"Automatic Lighting Enabled: {_lightingControl.IsLightingEnabled}");
        }
    } 
}
