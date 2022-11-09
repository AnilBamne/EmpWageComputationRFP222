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
            int employeePresent = 1;
            int empWage = 0;
            int empHrs = 0;

            Random r = new Random();
            int empCheck = r.Next(0, 2);
            if (empCheck == employeePresent)
            {
                Console.WriteLine("The employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("The Employee is abscent");
                empHrs = 0;
            }
            //UC2
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Daily Employee Wage is : "+empWage);

        }
    }
}
