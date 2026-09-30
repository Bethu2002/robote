using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPrototype
{
    public class EntertainmentRobot : IRobotPrototype
    {
        public string ModelName { get; set; }
        public double BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }
        public string EntertainmentFeature { get; set; }

        public IRobotPrototype Clone()
        {
            return new EntertainmentRobot
            {
                ModelName = this.ModelName,
                BatteryCapacity = this.BatteryCapacity,
                SoftwareVersion = this.SoftwareVersion,
                EntertainmentFeature = this.EntertainmentFeature
            };
        }

        public void Display()
        {
            Console.WriteLine("Entertainment Robot");
            Console.WriteLine($"Model Name: {ModelName}");
            Console.WriteLine($"Battery Capacity: {BatteryCapacity} hours");
            Console.WriteLine($"Software Version: {SoftwareVersion}");
            Console.WriteLine($"Entertainment Feature: {EntertainmentFeature}");
            Console.WriteLine();
        }
    }
}
