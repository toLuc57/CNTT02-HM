using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents.NewClassroom
{
    class VicoStudent : Student
    {
        public VicoStudent(string name) : base(name)
        {
            this.name = name;
            position = PositionVicoStudent;
        }
        public override double GetBonus()
        {
            bonus += 0.2;
            return bonus;
        }

    }
}
