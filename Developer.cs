using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Developer : Employee
    {
        public Developer()
        {
            Console.WriteLine("Enter Developer Id:");
            this.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Developer Name:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Developer Designation:");
            this.Designation = Console.ReadLine();
            Console.WriteLine("Enter Developer Experience:");
            this.Experience = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Developer JoiningDate");
            this.JoiningDate = Console.ReadLine(); 

        }
        public int Salary;
        private int AdditionalAmmount;
        private int BasicPay=8000;

        public override int salaryCalculation()
        {
            AdditionalAmmount = 2000 * this.Experience;
            int salary = BasicPay + AdditionalAmmount;
            return salary;
        }
    }
}
