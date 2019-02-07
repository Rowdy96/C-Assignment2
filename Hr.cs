using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    public class Hr : Employee
    {
        public Hr()
        {
            Console.WriteLine("Enter Hr Id:");
            this.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hr Name:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Hr Designation:");
            this.Designation = Console.ReadLine();
            Console.WriteLine("Enter Hr Experience:");
            this.Experience = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hr JoiningDate");
            this.JoiningDate = Console.ReadLine();
        }
        public int Salary;
        private int BasicPay = 8000;
        private int AdditionalAmmount;
        public override int salaryCalculation()
        {
            AdditionalAmmount = 1000 * this.Experience;
            int salary = BasicPay + AdditionalAmmount;
            return salary;
        }
    }
}
