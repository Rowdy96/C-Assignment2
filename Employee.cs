using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    
    public abstract class Employee
    {
       
        public int Id {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

  
        public string Designation
        {
            get;
            set;
        }
       
        public int Experience
        {
            get;
            set;
        }
        
        public int AnnualSalary
        {
            get;
            set;
        }
        
        public string JoiningDate
        {
            get;
            set;
        }
        public abstract int salaryCalculation();
    }
}
