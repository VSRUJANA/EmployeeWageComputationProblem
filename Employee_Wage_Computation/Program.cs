using System;

namespace Employee_Wage_Computation
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Employee Wage Computation Program");
                Console.WriteLine(Attendance());
            }


            static string Attendance()
            {
                int isPresent = 1;
                Random rand = new Random();
                int empCheck = rand.Next(0, 2);
                //1 => present and 0 => absent
                if (empCheck == isPresent)
                    return "Employee is present";
                else
                    return "Employee is absent";
            }
        }
    }
    
