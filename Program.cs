using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotFactory factory = new RobotFactory();

            // Create Service Robot prototype
            ServiceRobot serviceRobot = new ServiceRobot
            {
                ModelName = "SR-100",
                BatteryCapacity = 10,
                SoftwareVersion = "V1.0",
                ServiceTask = "Hospital Assistance"
            };

            // Create Industrial Robot prototype
            IndustrialRobot industrialRobot = new IndustrialRobot
            {
                ModelName = "IR-200",
                BatteryCapacity = 15,
                SoftwareVersion = "V2.0",
                IndustrialTask = "Welding"
            };

            // Create Entertainment Robot prototype
            EntertainmentRobot entertainmentRobot = new EntertainmentRobot
            {
                ModelName = "ER-300",
                BatteryCapacity = 8,
                SoftwareVersion = "V1.5",
                EntertainmentFeature = "Dancing and Talking"
            };

            // Add prototypes to factory
            factory.AddPrototype("Service", serviceRobot);
            factory.AddPrototype("Industrial", industrialRobot);
            factory.AddPrototype("Entertainment", entertainmentRobot);

            // Clone Service Robot
            ServiceRobot newServiceRobot =
                (ServiceRobot)factory.CloneRobot("Service");

            newServiceRobot.BatteryCapacity = 12;
            newServiceRobot.SoftwareVersion = "V1.1";

            // Clone Industrial Robot
            IndustrialRobot newIndustrialRobot =
                (IndustrialRobot)factory.CloneRobot("Industrial");

            newIndustrialRobot.BatteryCapacity = 18;
            newIndustrialRobot.SoftwareVersion = "V2.1";

            // Clone Entertainment Robot
            EntertainmentRobot newEntertainmentRobot =
                (EntertainmentRobot)factory.CloneRobot("Entertainment");

            newEntertainmentRobot.BatteryCapacity = 10;
            newEntertainmentRobot.SoftwareVersion = "V1.6";

            // Display robots
            serviceRobot.Display();
            newServiceRobot.Display();

            industrialRobot.Display();
            newIndustrialRobot.Display();

            entertainmentRobot.Display();
            newEntertainmentRobot.Display();

            Console.ReadLine();
        }
    }
}
