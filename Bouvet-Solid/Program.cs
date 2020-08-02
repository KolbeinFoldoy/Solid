using System;

namespace Bouvet_Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlUnit controlUnit = new ControlUnit();

            string input = "";
            while (!input.Equals("exit"))
            {
                Console.WriteLine("Type \"poll\" to poll all sensors once or \"exit\" to exit");
                input = Console.ReadLine();
                if (input.Equals("poll"))
                {
                    controlUnit.PollSensors();
                }
            }
        }
    }
}
