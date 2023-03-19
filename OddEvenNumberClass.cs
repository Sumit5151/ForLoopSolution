using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopDemo
{
    internal class OddEvenNumberClass
    {

        public void OddNumber()
        {
            Console.WriteLine("Please enter any limit");
            int limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i+ " ");
                }
            }
        }
    }
}
