using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents.NewClassroom
{
    class ClassMonitor : Student
    {
        public ClassMonitor(string name)
        {
            setName(name);
        }
        public override string getPosition()
        {
            return getName() + " :Class Monitor";
        }
        public override double getBound()
        {
            return 0;
        }
    }
}
