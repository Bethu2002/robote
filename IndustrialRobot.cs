using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RobotPrototype
{
    public class IndustrialRobot : IRobotPrototype
    {
        public string ModelName { get; set; }
        public double BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }
        public string IndustrialTask { get; set; }

        public IRobotPrototype Clone()
        {
            return new IndustrialRobot
            {
                ModelName = this.ModelName,
                BatteryCapacity = this.BatteryCapacity,
                SoftwareVersion = this.SoftwareVersion,
                IndustrialTask = this.IndustrialTask
            };
        }

        public void Display()
        {
            Console.WriteLine("Industrial Robot");
            Console.WriteLine($"Model Name: {ModelName}");
            Console.WriteLine($"Battery Capacity: {BatteryCapacity} hours");
            Console.WriteLine($"Software Version: {SoftwareVersion}");
            Console.WriteLine($"Industrial Task: {IndustrialTask}");
            Console.WriteLine();
        }
    }
}