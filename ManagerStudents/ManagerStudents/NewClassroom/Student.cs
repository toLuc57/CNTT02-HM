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
        protected int bonusConduct = 0;
        protected const string Position = "Normal Student";
        protected const string PositionClassMonitor = "Class Monitor";
        protected const string PositionVicoStudent = "Vico Student";
     

        public Student(string name)
        {
            this.name = name;
        }

        public static void GetMenu()
        {
            Console.WriteLine("Name\tPosition\tBound\tConduct");
            Console.WriteLine("---------------------------");
        }

        public void SetBonusConduct(int bonusConduct)
        {
            this.bonusConduct = bonusConduct;
        }
        public virtual int GetBonusConduct()
        {
            return bonusConduct;
        }
        public string GetName()
        {
            return name;
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
                    this.position = PositionClassMonitor;
                    break;
                case 2:
                    ClassMonitor classMonitor = new ClassMonitor(name);
                    bonus = classMonitor.GetBonus();
                    this.position = PositionVicoStudent;
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
            Console.WriteLine(GetName() + '\t' + GetPosition() + '\t' + GetBonus()
                + '\t' + GetBonusConduct());
        }
        
    }
}
