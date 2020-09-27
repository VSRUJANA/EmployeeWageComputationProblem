using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Employee wage : " + EmployeeDailyWageComputation());
        }
        static int EmployeeDailyWageComputation()
        {
            int isPresent = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            int workHrs = 0;
            int empWage = 0;
            int wagePerHour = 20;
            if (empCheck == isPresent)
            {
                workHrs = 8;
            }
            empWage = workHrs * wagePerHour;//Computation of daily wage: 
            return empWage;
        }

    }
}
    
