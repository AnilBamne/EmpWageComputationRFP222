﻿using System;

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
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int empWage = 0;
            int empHrs = 0;

            Random r = new Random();
            int empCheck = r.Next(0, 3);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("The employee Is_Full_Time present");
                empHrs = 8;
            }
            else if(empCheck == Is_Part_Time)
            {
                Console.WriteLine("The employee Is_Part_Time present");
                empHrs = 4;
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
