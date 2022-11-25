using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationRFP222
{
    public class CompanyEmpWage
    {
        //defining global variables
        public string company;
        public int empRatePerHour;
        public int maxWorkingDaysPerMonth;
        public int maxWorkingHrsPerMonth;
        public int totalEmpWage;
        //initialized in constructor
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)//initializing all variabeles
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.maxWorkingDaysPerMonth = numOfWorkingDays;
            this.maxWorkingHrsPerMonth = maxHoursPerMonth;
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        //representing objects into string so it can be readable .
        public override string ToString()
        {
            return "Total Emp Wage for company : " + this.company + " is : " + this.totalEmpWage;
        }
    }

}
