using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopDemo
{
    internal class Pattern
    {

        public static void Pattern1()
        {

            Console.WriteLine("Please enter the limit");
            string str = Console.ReadLine();
            var limit = Convert.ToInt32(str);
           

            //limit = 5
            for (int i = 1; i <= limit; i++)
            {
                for (int j = 1; j <= limit; j++)
                {
                    Console.Write(j+" ");
                }

                Console.WriteLine();
            }

        }



        public static void Pattern2()
        {

            Console.WriteLine("Please enter the limit");
            string str = Console.ReadLine();
            var limit = Convert.ToInt32(str);

        

            //limit = 5
            for (int i = 1; i <= limit; i++)
            {
                for (var j = limit; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }

        }



        public static void Pattern3()
        {
            Console.WriteLine("Please enter the value for rows");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the value for columns");
            int columns = Convert.ToInt32(Console.ReadLine());




            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(" "+ Convert.ToChar(96 +i));
                }
                Console.WriteLine();
            }

        }


        //1 2 3
        //4 5 6
        //7 8 9
        
        public static void Pattern4()
        {
            int k = 1;
            for (int i = 1; i <= 3; i++)
            {


                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(Convert.ToChar(64 + k++));
                }


                Console.WriteLine();
            }

        }
    }
}
