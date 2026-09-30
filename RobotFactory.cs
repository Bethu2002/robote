using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace RobotPrototype
{
    public class RobotFactory
    {
        private Dictionary<string, IRobotPrototype> prototypes =
            new Dictionary<string, IRobotPrototype>();

        public void AddPrototype(string name, IRobotPrototype robot)
        {
            prototypes[name] = robot;
        }

        public IRobotPrototype CloneRobot(string name)
        {
            return prototypes[name].Clone();
        }
    }
}