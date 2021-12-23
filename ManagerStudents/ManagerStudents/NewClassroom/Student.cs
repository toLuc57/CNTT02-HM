using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents.NewClassroom
{
    abstract class Student
    {
        String name;
        public void setName(string name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
        public abstract string getPosition();
        public abstract double getBound();
    }
}
