using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee(5, 101);

            Console.WriteLine($"emp years of service: {emp.YearsOfService}");
            Console.WriteLine($"emp Office: {emp.Office}");

            var emp2 = new Employee
            {
                YearsOfService = 15,
                Office = 102
            };

            Console.WriteLine($"emp2 years of service: {emp2.YearsOfService}");
            Console.WriteLine($"emp2 Office: {emp2.Office}");

        }
    }

}
