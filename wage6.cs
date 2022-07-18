using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage6
{
    internal class wage6
    {
        public static void Empwage6()
        {
            int fullTime = 1;  
            int partTime = 2;
            int Emp_hr = 0;
            int empWage = 0;
            int wagePerHR = 20;
            int totalWorkingdays = 20;
            int totalWorkingHR = 100;
            int Total_Emphr = 0;
            int totalDay = 0;
            do
            {
                
                Random random = new Random();
                int attendCheck = random.Next(0, 3);
                if (attendCheck == fullTime)
                {
                    Emp_hr = 8;
                    Console.WriteLine($"Full time employee");
                }
                else if (attendCheck == partTime)
                {
                    Emp_hr = 4;
                    Console.WriteLine("Part time employee");
                }
                else
                {
                    Emp_hr = 0;
                    Console.WriteLine("The employee is absent");
                }
                Total_Emphr = Total_Emphr + Emp_hr;
                empWage = Emp_hr * wagePerHR;
                Console.WriteLine("Employee wage is :  " + empWage);
                totalDay++;
            } while (Total_Emphr <= totalWorkingHR && totalDay < totalWorkingdays);
            Console.WriteLine($"The total working days per month is {totalWorkingdays} and total working hours is {Total_Emphr}");
            empWage = Total_Emphr * wagePerHR;
            Console.WriteLine("Employee wage is :  " +empWage);
        }
    }
}
