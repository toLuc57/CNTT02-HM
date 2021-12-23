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

        // Dặt tên kiểu PascalCase : SetName 
        public void setName(string name)
        {
            this.name = name;
        }

        // Dặt tên kiểu PascalCase : GetName
        public String getName()
        {
            return name;
        }

        // Dặt tên kiểu PascalCase : GetPosition
        public abstract string getPosition();

        // Dặt tên kiểu PascalCase : GetBound
        public abstract double getBound();
    }
}
