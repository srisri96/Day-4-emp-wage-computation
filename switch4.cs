using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage4
{
    internal class switch4
    {
        public static void case4()
        {
            const int fullTime = 1;
            const int partTime = 2;
            int empHr = 0;
            int empWage = 0;
            int wagePerHr = 20;
            Random random = new Random();
            int attendCheck = random.Next(0, 3);
            switch (attendCheck)
            {
                case fullTime:
                    empHr = 8;
                    
                    break;
                case partTime:
                    empHr = 4;
                
                    break;
                default:
                    empHr = 0;
                 
                    break;
            }
            empWage = empHr * wagePerHr;
            Console.WriteLine("The Employee wage is : "  +empWage);
        }
    }
}
