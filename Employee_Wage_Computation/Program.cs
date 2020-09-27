using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Employee wage: " + EmpDailyWageUsingSwitch());
        }
        static int EmpDailyWageUsingSwitch()
        {
            int wagePerHour = 20;
            int workHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            //switch case to calculate wages
            switch (empCheck)
            {
                case 0:         //0. Full time present.
                    workHrs = 8;
                    break;
                case 1:         //1. Part time present.
                    workHrs = 4;
                    break;
                default:        // Absent
                    workHrs = 0;
                    break;
            }
            int empWage = workHrs * wagePerHour;
            return empWage;
        }
    }
}

