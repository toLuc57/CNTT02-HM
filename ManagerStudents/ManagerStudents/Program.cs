using ManagerStudents.NewClassroom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Manager Students--");
            List<Student> classroom1 = new List<Student>();
            Console.Write("Number of students: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            if (n > 2)
            {
                Console.WriteLine("Class Monitor? ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Point: ");
                double point = Convert.ToDouble(Console.ReadLine());
                classroom1.Add(new ClassMonitor(name, point));

                Console.WriteLine("Vico Class? ");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Point: ");
                point = Convert.ToDouble(Console.ReadLine());
                classroom1.Add(new VicoStudent(name, point));

                i += 2;
            }

            while(i<n)
            {
                Console.WriteLine("Student index " + ++i + ": ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Point: ");
                double point = Convert.ToDouble(Console.ReadLine());
                classroom1.Add(new OtherStudent(name,point));
                
            }
            Console.WriteLine();
            Console.WriteLine("--Members in classroom--");
            Student.GetMenu();
            foreach (Student student in classroom1)
            {
                student.GetInformation();
            }

            Console.ReadLine();
        }
    }
}
