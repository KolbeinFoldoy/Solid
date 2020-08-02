using Bouvet_Solid;
using Xunit;

namespace Tests
{
    public class SmokeSensorTest
    {
        [Fact]
        public void TestThatIsTriggeredReturnsFalse()
        {
            SmokeSensor sensor = new SmokeSensor();
            bool isTriggered = sensor.IsTriggered();
            Assert.False(isTriggered);
        }

        [Fact]
        public void TestThatGetLocationReturnsNull()
        {
            SmokeSensor sensor = new SmokeSensor();
            string location = sensor.GetLocation();
            Assert.Null(location);
        }

        [Fact]
        public void TestThatGetSensorTypeReturnsNull()
        {
            SmokeSensor sensor = new SmokeSensor();
            string sensorType = sensor.GetSensorType();
            Assert.Null(sensorType);
        }

        [Fact]
        public void TestThatGetBatteryPercentageReturnsNegativeOne()
        {
            SmokeSensor sensor = new SmokeSensor();
            double batteryPercentage = sensor.GetBatteryPercentage();
            Assert.Equal(-1.0, batteryPercentage);
        }
    }
}
