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
            int Is_FullTime = 1;
            Random r = new Random();
            int empCheck = r.Next(0, 2);

            if (empCheck == Is_FullTime)
            {
                Console.WriteLine("The employee is present");
            }
            else
            {
                Console.WriteLine("The Employee is abscent");
            }
        }
    }
}
