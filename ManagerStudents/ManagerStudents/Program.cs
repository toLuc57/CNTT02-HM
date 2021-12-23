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

            Console.WriteLine("Class Monitor? ");
            string name = Console.ReadLine();
            classroom1.Add(new ClassMonitor(name));

            Console.WriteLine("Vico Class? ");
            name = Console.ReadLine();
            classroom1.Add(new VicoStudent(name));
            for (int i=0; i < 8; ++i)
            {
                name = Console.ReadLine();
                classroom1.Add(new OtherStudent(name));
            }
            Console.WriteLine("--Members in classroom--");
            foreach(Student student in classroom1)
            {
                student.getPosition();
            }
        }
    }
}
