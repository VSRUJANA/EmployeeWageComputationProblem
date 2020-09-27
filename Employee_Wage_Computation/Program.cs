using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Employee wage: " + EmployeeWageWithCondition());
        }
        static int EmployeeWageWithCondition()
        {
            int empMonthlyWage = 0, wagePerHour = 20, totalWorkHrs = 0, workDays = 0;
            int isPresent = 1, isFullTime = 1;
            Random random = new Random();
            int empType = random.Next(0, 2);
            int hrsPerDay = (empType == isFullTime) ? 8 : 4;
            for (int i = 0; i < 30; i++)
            {
                int empCheck = random.Next(0, 2);
                if (totalWorkHrs > 100 || workDays > 20)
                    break;
                if (empCheck == isPresent)
                {
                    totalWorkHrs += hrsPerDay;
                    workDays++;
                }

            }
            empMonthlyWage = wagePerHour * totalWorkHrs;
            Console.WriteLine($"Employee worked for {totalWorkHrs} hours OR {workDays} days ");
            return empMonthlyWage;
        }
    }
}

