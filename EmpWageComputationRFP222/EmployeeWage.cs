using System;

namespace EmpWageComputationRFP222
{
    public class EmployeeWage
    {
        static void Main(string[] args)
        {
            //main
            Console.WriteLine("Welcome To EmployeeWageComputation");
            //UC8 Class method with parameters
            ComputeEmpWage("Reliance",20,30,100);
            ComputeEmpWage("Tata",25,26,100);
            ComputeEmpWage("Bajaj",28,28,110);
        }
        public static void ComputeEmpWage(String company,int empRatePerHr,int maxWorkingDaysPerMonth,int maxWorkingHrsPerMonth)
        {
            //Constants
            const int Is_Full_Time = 1;
            const int Is_Part_Time = 2;
           
            //Variables
            int TotalWorkingHrs = 0;
            int TotalWageOfMonth = 0;
            int empWage, empHrs;
            int empWorkingDays = 0;
            //computation
            while (TotalWorkingHrs <= maxWorkingHrsPerMonth && empWorkingDays <= maxWorkingDaysPerMonth)
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
                //computing wage
                empWage = empRatePerHr * empHrs;
                TotalWageOfMonth += empWage;
                TotalWorkingHrs += empHrs;
            }
            Console.WriteLine(" For "+company+" :\nTotal Employee Wage of a month is : " + TotalWageOfMonth);
        }
    }
}
