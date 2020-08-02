namespace Bouvet_Solid
{
    public interface ISensor
    {
        bool IsTriggered();
        string GetLocation();
        string GetSensorType();
        double GetBatteryPercentage();
    }
}
