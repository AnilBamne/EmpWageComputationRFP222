using System;

namespace EmpWageComputationRFP222
{
    public class EmployeeWageBuilder
    {
        //defining constants
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        private int numOfCompany = 0;
        //defining arry to store multiple company details and computing their wages
        private CompanyEmpWage[] CompanyEmpWageArray;//Array created of class CompanyEmpWage by the name companyEmpWageArray.
        public EmployeeWageBuilder()//constructor to initialize 
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[5];// array size is 5.
        }
        //Adding multiple companies
        public void AddCompanyEmpWage(string company, int empRateperHour, int maxWorkingDaysPerMonth, int maxWorkingHrsPerMonth)
        {
            CompanyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRateperHour, maxWorkingDaysPerMonth, maxWorkingHrsPerMonth);
            numOfCompany++;
        }
        //computing wages
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                CompanyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.CompanyEmpWageArray[i]));
                Console.WriteLine(this.CompanyEmpWageArray[i].ToString());
            }
        }
        //providing class object as parameter to method
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)    //Computing the wages for each company
        {
            //Variables
            int TotalWorkingHrs = 0;
            int empHrs;
            int empWorkingDays = 0;
            //computation
            while (TotalWorkingHrs <= companyEmpWage.maxWorkingHrsPerMonth && empWorkingDays < companyEmpWage.maxWorkingDaysPerMonth)
            {
                empWorkingDays++;
                Random r = new Random();
                int empCheck = r.Next(0, 3);
                //UC4
                switch (empCheck)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                //computing total working hours
                TotalWorkingHrs += empHrs;
            }
            //Total employee wage for each company
            companyEmpWage.totalEmpWage = TotalWorkingHrs * companyEmpWage.empRatePerHour;
            return companyEmpWage.totalEmpWage;
        }
    }
    public class EmployeeWage
    { 
        public static void Main(string[] args)
        {
            //main
            Console.WriteLine("Welcome To EmployeeWageComputation");
            //UC10 manage emp wage for multiple companies
            EmployeeWageBuilder employeeWageBuilder = new EmployeeWageBuilder();
            employeeWageBuilder.AddCompanyEmpWage("Tata",30,28,100);
            employeeWageBuilder.AddCompanyEmpWage("Bajaj",20,29,105);
            employeeWageBuilder.AddCompanyEmpWage("Jio",22,27,110);
            employeeWageBuilder.ComputeEmpWage();
        }
    }
}
