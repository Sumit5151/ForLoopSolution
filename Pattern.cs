using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopDemo
{
    internal class Pattern
    {
        public int num { get; set; }

        void GetNumberFromUser()
        {
            Console.WriteLine("Please enter any number");
            num = Convert.ToInt32(Console.ReadLine());
        }


        public void StarPattern1()
        {
            GetNumberFromUser();

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void StarPattern2()
        {
            GetNumberFromUser();

            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        public void StarPattern3()
        {
            GetNumberFromUser();

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void StarPattern4()
        {
            GetNumberFromUser();

            for (int i = num; i >= 1; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }


        public void StarPattern5()
        {
            GetNumberFromUser();

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int i = num-1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int i = num - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }


        public void StarPattern6()
        {
            GetNumberFromUser();

            for (int i = 1; i <= num; i++)
            {
                // 4
                // 3
                // 2
                // 1

                                     
                for (int k = 1; k <=num-i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= i-1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }



            for (int i = num-1; i >= 1; i--)
            {
                // 4
                // 3
                // 2
                // 1


                for (int k = 1; k <= num - i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }


            public static void Staticfunction1()
        {

        }

        public static void Staticfunction2()
        {
            Staticfunction1();

            Pattern pattern = new Pattern();
            pattern.NonStaticFunction1();
        }


        public void NonStaticFunction1()
        {
            Staticfunction1();
            NonStaticFunction2();
        }


        public void NonStaticFunction2()
        {

        }




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
                    Console.Write(j + " ");
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
                    Console.Write(" " + Convert.ToChar(96 + i));
                }
                Console.WriteLine();
            }

        }
        //This is changed

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
