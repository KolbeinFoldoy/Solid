using Bouvet_Solid;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using Xunit;

namespace Tests
{
    public class FireSensorTest
    {
        [Fact]
        public void TestThatIsTriggeredReturnsFalse()
        {
            FireSensor sensor = new FireSensor();
            bool isTriggered = sensor.IsTriggered();
            Assert.False(isTriggered);
        }

        [Fact]
        public void TestThatGetLocationReturnsNull()
        {
            FireSensor sensor = new FireSensor();
            string location = sensor.GetLocation();
            Assert.Null(location);
        }

        [Fact]
        public void TestThatGetSensorTypeReturnsNull()
        {
            FireSensor sensor = new FireSensor();
            string sensorType = sensor.GetSensorType();
            Assert.Null(sensorType);
        }

        [Fact]
        public void TestThatGetBatteryPercentageReturnsNegativeOne()
        {
            FireSensor sensor = new FireSensor();
            double batteryPercentage = sensor.GetBatteryPercentage();
            Assert.Equal(-1.0, batteryPercentage);
        }
    }
}
