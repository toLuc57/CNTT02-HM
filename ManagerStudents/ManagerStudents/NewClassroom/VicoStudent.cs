using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents.NewClassroom
{
    class VicoStudent : Student
    {
        public VicoStudent(String name)
        {
            setName(name);
        }
        public override string getPosition()
        {
            return getName() + ": Vico Student";
        }
        public override double getBound()
        {
            return 0.2;
        }
    }
}
