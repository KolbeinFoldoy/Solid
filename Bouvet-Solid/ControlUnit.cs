using System;
using System.Collections.Generic;

namespace Bouvet_Solid
{
    public class ControlUnit
    {
        public void PollSensors()
        {
            List<ISensor> sensors = new List<ISensor>();
            sensors.Add(new FireSensor());
            sensors.Add(new SmokeSensor());

            foreach (var sensor in sensors)
            {
                if (sensor.IsTriggered())
                {
                    Console.WriteLine("A " + sensor.GetSensorType() + " sensor was triggered at " + sensor.GetLocation());
                }
                else
                {
                    Console.WriteLine("Polled " + sensor.GetSensorType() + " at " + sensor.GetLocation() + " successfully");
                }
            }
        }
    }
}
