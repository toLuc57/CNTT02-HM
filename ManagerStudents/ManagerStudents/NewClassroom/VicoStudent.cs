using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents.NewClassroom
{
    class VicoStudent : Student
    {
        public VicoStudent(String name,double point)
        {
            SetName(name);
            SetPoint(point);
            SetBound(0.2);
        }
    }
}
