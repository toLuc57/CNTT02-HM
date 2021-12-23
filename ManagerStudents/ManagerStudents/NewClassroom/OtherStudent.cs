using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents.NewClassroom
{
    class OtherStudent : Student
    {
        public OtherStudent(string name,double point)
        {
            SetName(name);
            SetPoint(point);
        }
    }
}
