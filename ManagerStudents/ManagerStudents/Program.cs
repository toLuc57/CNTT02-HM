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

            classroom1.Add(new ClassMonitor("abc"));
            classroom1.Add(new VicoStudent("@qwwe"));
            classroom1.Add(new Student("!23"));

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
