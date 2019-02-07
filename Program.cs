using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        
        public static void Main(string[] args)
        {

           //hr 
            Hr hr = new Hr();
            hr.Salary = hr.salaryCalculation();
            Console.WriteLine($"HR {hr.Name}'s Salary: {hr.Salary}");
            //developer
            Developer developer = new Developer();
            developer.Salary=developer.salaryCalculation();
            Console.WriteLine($"Dveloper {developer.Name}'s Salary:{ developer.Salary}");
            

            Console.ReadKey();
        }
    }
}
