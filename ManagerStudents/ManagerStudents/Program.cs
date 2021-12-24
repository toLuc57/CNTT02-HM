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

            Student.InforamationOfPosition();

            for (int i=1; i <= n; ++i)
            {
                Console.WriteLine("Student index " + i + ": ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Position: ");
                int position = int.Parse(Console.ReadLine());
                classroom1.Add(new Student(name,position));
                
            }
            Console.WriteLine();
            Console.WriteLine("--Members in classroom--");
            Student.GetMenu();
            foreach (Student student in classroom1)
            {
                student.GetInformation();
            }
            Console.WriteLine("------------------------------------------");

            Console.ReadLine();
        }
    }
}
