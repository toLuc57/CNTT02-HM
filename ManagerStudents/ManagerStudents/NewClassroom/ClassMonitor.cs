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
        }
        public override double GetBonus()
        {
            bonus += 0.5;
            return base.GetBonus();
        }
        public override int GetBonusConduct()
        {
            bonusConduct += 2;
            return base.GetBonusConduct();
        }

    }
}
