namespace Bouvet_Solid
{
    public class FireSensor : ISensor
    {
        public bool IsTriggered()
        {
            return false;
        }

        public string GetLocation()
        {
            return null;
        }

        public string GetSensorType()
        {
            return null;
        }

        public double GetBatteryPercentage()
        {
            return -1;
        }
    }
}
