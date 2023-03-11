

using ForLoopDemo;
using System;

public class Program
{
    public static void Main()
    {
        //PrintNumbers();
        //NestedLoop();

        //Pattern.Pattern1();
        //Pattern.Pattern2();
        //Pattern.Pattern3();
        //Pattern.Pattern4();
        //Pattern.Staticfunction1();
        

        Pattern patternObj1 = new Pattern();       
        //patternObj1.StarPattern1();
        //patternObj1.StarPattern2();
        //patternObj1.StarPattern3();
        //patternObj1.StarPattern4();
        //patternObj1.StarPattern5();
        patternObj1.StarPattern6();



        //Pattern patternObj2= new Pattern();
        //patternObj2.num = 20;

        //patternObj1.StarPattern2();
        
        //patternObj2.StarPattern2();


    }


    private static void PrintNumbers()
    {

        //int i;  //declaration
        // i = 0; //initialization



        //initialization                              //condition                 // increment or decrement
        //for (int i = 0, j = 3, k = 400, m = 9898; i > 1 && j <= 10 || k == 20 && m > 500; i--, j++, k = k + 4)
        //{

        //}

        //Q print numbers from 10, 8 6 4 2 0

        //for (int i = 10; i >=0 ; i=i-2)
        //{
        //    Console.WriteLine(i);
        //}


        //Q print numbers from 5 10 15 20  ...50

        for (int i = 5; i <= 50; i = i + 5)
        {
            Console.WriteLine(i);
        }


        //Q print numbers from 100 90 80 70 60 ...10

        for (int i = 100; i >= 10; i = i - 10)
        {

        }


        //Q print numbers from 6 12 18 24 30.....60

        for (int i = 6; i <= 60; i = i+6)
        {

        }

    }

    public static void NestedLoop()
    {
        //for (int i = 1; i <= 5; i++) //rows
        //{

        //    for (int j = 1; j <= 10; j++)//columns
        //    {
        //        Console.Write(" * ");
        //    }

        //    Console.WriteLine();

        //}

        //7 X 12

        //for (int i = 1; i <= 7; i++) //rows
        //{

        //    for (int j = 1; j <= 12; j++)//columns
        //    {
        //        Console.Write(" * ");
        //    }

        //    Console.WriteLine();

        //}



        for (int i = 5; i >= 1; i--) //rows
        {

            for (int j = 1; j <= 5; j++)//columns
            {
                Console.Write(i);
            }

            Console.WriteLine();

        }



    }
}
