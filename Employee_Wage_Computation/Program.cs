using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Employee monthly wage: " + EmployeeMonthlyWageComputation());
        }
        static int EmployeeMonthlyWageComputation()
        {
            int isFullTime = 1;
            int wagePerHour = 20;
            int workHrs = 0;
            int WorkingDays = 0;
            int empCheck = 0;
            Random random = new Random();
            for (int day = 0; day < 20; day++)
            {
                empCheck = random.Next(0, 2);
                WorkingDays = WorkingDays + empCheck;
            }
            Console.WriteLine("No. of days worked in the month :" + WorkingDays);
            int empType = random.Next(0, 2);
            if (empType == isFullTime)
            {
                workHrs = 8;
                Console.WriteLine("Emp Type : Full time Employee");
            }
            else
            {
                workHrs = 4;
                Console.WriteLine("Emp Type : Part time Employee");
            }
            return workHrs * WorkingDays * wagePerHour;
        }
    }
}

