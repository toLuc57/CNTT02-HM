using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents.NewClassroom
{
    class Student
    {
        protected string name;
        protected double bonus = 0;
        protected string position = "Student";

        public static void GetMenu()
        {
            Console.WriteLine("Name\tPosition\tBound");
            Console.WriteLine("---------------------------");
        }
        public static void InforamationOfPosition()
        {
            Console.WriteLine("---------------Position-------------------");
            Console.WriteLine("0: Students");
            Console.WriteLine("1: Vico Student");
            Console.WriteLine("2: Class Monitor");
            Console.WriteLine("------------------------------------------");
        }
        public Student()
        {
        }

        public Student(string name,int position = 0)
        {
            this.name = name;
            SetPosition(position);
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        // Dặt tên kiểu PascalCase : GetName
        public string GetName()
        {
            return name;
        }
        public void SetBonus(double bonus)
        {
            this.bonus = bonus;
        }
        public virtual double GetBonus()
        {
            return bonus;
        }
        public void SetPosition(int position)
        {
            switch (position)
            {
                case 0:
                    break;
                case 1:
                    VicoStudent vicoStudent = new VicoStudent(name);
                    bonus = vicoStudent.GetBonus();
                    this.position = "Vico Student";
                    break;
                case 2:
                    ClassMonitor classMonitor = new ClassMonitor(name);
                    bonus = classMonitor.GetBonus();
                    this.position = "Class Monitor";
                    break;
                default:
                    Console.WriteLine("Input value in [0,2].");
                    Console.Write("Position: ");
                    SetPosition(int.Parse(Console.ReadLine()));
                    break;
            }
        }
        public string GetPosition()
        {
            return position;
        }
        public void GetInformation()
        {
            Console.WriteLine(GetName() + '\t' + GetPosition() + '\t' + GetBonus());
        }
        
    }
}
