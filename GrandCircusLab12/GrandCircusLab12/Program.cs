using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Program
    {
        static void Main()
        {
            Person Michael = new Person("Michael Hern", "123 Main St.");
            Student Sarah = new Student("Sarah Hern", "123 Main St.", "Education", 3, 4000.00);
            Staff Daphne = new Staff("Daphne Hern", "123 Main St.", "University of Michigan", 75000.00);
            Console.WriteLine(Michael.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(Sarah.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(Daphne.ToString());
            Console.WriteLine("\n");
            Daphne.EditSchool("Eastern Michigan University");
            Console.WriteLine(Daphne.ToString());
            


            Console.ReadKey();
        }
    }
}
