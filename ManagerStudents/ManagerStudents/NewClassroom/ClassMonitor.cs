using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents.NewClassroom
{
    class ClassMonitor : Student
    {
        public ClassMonitor(string name):base(name)
        {
            this.name = name;
            position = PositionClassMonitor;
            SetBonusHk(2 + GetBonusHk());
        }
        public override double GetBonus()
        {
            bonus += 0.5;
            return bonus;
        }

    }
}
