using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents.NewClassroom
{
    class ClassMonitor : Student
    {
        public ClassMonitor(string name,double point)
        {
            SetName(name);
            SetPoint(point);
            SetBound(0.5);
        }
    }
}
