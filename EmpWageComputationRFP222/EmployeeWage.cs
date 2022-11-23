using System;

namespace EmpWageComputationRFP222
{
    public class EmployeeWageBuilder
    {
        //used a employee wage builder class and computed employee wage of each company,and saved it.
        //defining variables globally
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        private string company;
        private int empRatePerHr;
        private int maxWorkingDaysPerMonth;
        private int maxWorkingHrsPerMonth;
        public int totalEmpWage;
        //constructor 
        public EmployeeWageBuilder(string company, int empRatePerHr, int maxWorkingDaysPerMonth, int maxWorkingHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.maxWorkingDaysPerMonth = maxWorkingDaysPerMonth;
            this.maxWorkingHrsPerMonth = maxWorkingHrsPerMonth;
        }

        public void ComputeEmpWage()
        {
            //Variables
            int TotalWorkingHrs = 0;
            int empHrs;
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
                TotalWorkingHrs += empHrs;
            }
            totalEmpWage = TotalWorkingHrs * empRatePerHr;
            Console.WriteLine(" For " + company + " :\nTotal Employee Wage of a month is : " + totalEmpWage);
        }
    }
    public class EmployeeWage
    { 
        public static void Main(string[] args)
        {
            //main
            Console.WriteLine("Welcome To EmployeeWageComputation");
            //UC8 Class method with parameters
            //ComputeEmpWage("Reliance", 20, 30, 100);
            //ComputeEmpWage("Tata", 25, 26, 100);
            //ComputeEmpWage("Bajaj", 28, 28, 110);
            //UC9:Save the wage for each company
            EmployeeWageBuilder Reliance = new EmployeeWageBuilder("Reliance", 20, 30, 100);
            EmployeeWageBuilder Tata = new EmployeeWageBuilder("Tata", 25, 26, 100);
            EmployeeWageBuilder Bajaj = new EmployeeWageBuilder("Bajaj", 28, 28, 110);
            Reliance.ComputeEmpWage();
            Tata.ComputeEmpWage();
            Bajaj.ComputeEmpWage();
        }
    }
}
