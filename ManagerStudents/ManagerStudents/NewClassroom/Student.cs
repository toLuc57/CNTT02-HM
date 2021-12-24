using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents.NewClassroom
{
    abstract class Student
    {
        string name;
        double point;
        double bonus = 0;
        int bonusHk = 0;
        public Student()
        {
        }
        public Student(string name, double bonus, int hk)
        {
            this.name = name;
            point = -1;
            this.bonus = bonus;
            this.bonusHk = bonusHk;
        }
        public Student(string name,double point, double bonus, int bonusHk)
        {
            this.name = name;
            this.point = point;
            this.bonus = bonus;
            this.bonusHk = bonusHk;
        }
        // Dặt tên kiểu PascalCase : SetName 
        public void SetName(string name)
        {
            this.name = name;
        }

        // Dặt tên kiểu PascalCase : GetName
        public string GetName()
        {
            return name;
        }
        public void SetPoint(double point)
        {
            if(point >=0 && point <= 10)
            {
                this.point = point;
            }
            else
            {
                Console.WriteLine("Point in [0,10].");
                Console.Write("Point: ");
                SetPoint(double.Parse(Console.ReadLine()));
            }
        }
        public double GetPoint()
        {
            return point;
        }
        public void SetBonusHk(int bonusHk)
        {
            this.bonusHk = bonusHk;
        }
        public int GetBonusHk()
        {
            return bonusHk;
        }
        // Dặt tên kiểu PascalCase : GetPosition
        public void GetInformation()
        {
            Console.WriteLine(GetName() + '\t' + GetPoint() 
                + '\t' + GetBound() + '\t' + GetTotal() + '\t' + GetHk());
        }

        public void SetBound(double bonus)
        {
            this.bonus = bonus;
        }
        public virtual double GetBound()
        {
            return bonus;
        }
        public double GetTotal()
        {
            return point + bonus;
        }
        public static void GetMenu()
        {
            Console.WriteLine("Name\tPoint\tBound\tTotal\tHK");
            Console.WriteLine("------------------------------");
        } 
    }
}
