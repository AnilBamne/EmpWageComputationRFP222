using System;

namespace EmpWageComputationRFP222
{
    public class EmployeeWage
    {
        static void Main(string[] args)
        {
            //main
            Console.WriteLine("Welcome To EmployeeWageComputation");
            //UC7
            ComputeEmpWage();
        }
        public static void ComputeEmpWage()
        {
            const int EMP_RATE_PER_HR = 20;
            //UC3
            const int Is_Full_Time = 1;
            const int Is_Part_Time = 2;
            //UC5
            const int MaxWorkingDaysPerMonth = 20;
            const int MaxWorkingHrsPerMonth = 100;
            int TotalWorkingHrs = 0;
            int TotalWageOfMonth = 0;
            int empWage = 0;
            int empHrs = 0;
            int empWorkingDays = 0;

            while (TotalWorkingHrs <= MaxWorkingHrsPerMonth && empWorkingDays < MaxWorkingDaysPerMonth)
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
                //UC2
                empWage = EMP_RATE_PER_HR * empHrs;
                TotalWageOfMonth += empWage;
                TotalWorkingHrs += empHrs;
                //Console.WriteLine("working day is : " + empWorkingDays);
                //Console.WriteLine("Total working hrs : " + TotalWorkingHrs);
                //Console.WriteLine("Employee Wage is : " + TotalWageOfMonth + "\n");
            }
            Console.WriteLine("Total Employee Wage of a month is : " + TotalWageOfMonth);
        }
    }
}
