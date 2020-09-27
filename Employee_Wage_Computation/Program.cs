using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Employee wage: " + EmpDailyWageForFullAndPartTime());
        }
        static int EmpDailyWageForFullAndPartTime()
        {
            int workHrs = 0;
            int empWage = 0;
            int wagePerHour = 20;
            int isFullTime = 1;
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if (empCheck == isFullTime)
            {
                workHrs = 8;
            }
            else
            {
                workHrs = 4;  //Assuming part time hours as 4
            }
            empWage = workHrs * wagePerHour;
            return empWage;
        }

    }
}
    
