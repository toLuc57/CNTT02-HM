using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents.NewClassroom
{
    class VicoStudent : Student
    {
        public VicoStudent(string name,double point)
        {
            SetName(name);
            SetPoint(point);
            SetBound(0.2 + GetBound());
            SetBonusHk(1 + GetBonusHk());
        }
    }
}
