using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents.NewClassroom
{
    class OtherStudent : Student
    {
        public OtherStudent(string name)
        {
            setName(name);
        }
        // Dặt tên kiểu PascalCase : GetPosition
        public override string getPosition()
        {
            return getName() + ": Student";
        }
        // Dặt tên kiểu PascalCase : GetBound
        public override double getBound()
        {
            return 0;
        }
    }
}
