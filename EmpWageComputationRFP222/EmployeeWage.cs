using System;

namespace EmpWageComputationRFP222
{
    public class EmployeeWage
    {
        static void Main(string[] args)
        {
            //main
            Console.WriteLine("Welcome To EmployeeWageComputation");
            //UC1
            const int EMP_RATE_PER_HR = 20;
            //UC3
            const int Is_Full_Time = 1;
            const int Is_Part_Time = 2;
            int empWage = 0;
            int empHrs = 0;

            Random r = new Random();
            int empCheck = r.Next(0, 3);
            //UC4
            switch (empCheck)
            {
                case Is_Full_Time:
                    Console.WriteLine("The employee Is_Full_Time present");
                    empHrs = 8;
                    break;
                case Is_Part_Time:
                    Console.WriteLine("The employee Is_Part_Time present");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("The Employee is abscent");
                    empHrs = 0;
                    break;
            }
            //UC2
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Daily Employee Wage is : "+empWage);

        }
    }
}
