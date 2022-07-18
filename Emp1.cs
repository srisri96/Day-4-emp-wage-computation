using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee4
{
    public class Emp1
    {
        public void wage()
        {
            int Full_Time = 1;
            Random random = new Random();
            int attendCheck = random.Next(0, 2);
            if (attendCheck == Full_Time)
            {
                Console.WriteLine("The Employee is present");
            }
            else
            {
                Console.WriteLine("The Employee is absent");
            }
        }
    }
}
