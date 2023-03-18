using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopDemo
{
    internal class LogicalPrograms
    {

        public void CalculateLCM()
        {
            int num1, num2;
            int lcm=0;
            Console.WriteLine("Please enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            //10
            for (int i = num2; i <= num1 * num2; i++)
            {

                if (i % num1 == 0 && i % num2 == 0)
                {
                    lcm = i;
                    break;
                }
            }


            int GDC = (num1 * num2) / lcm;


            Console.WriteLine("LCM = " + lcm);
            Console.WriteLine("GCD = " + GDC);

        }
    }
}
