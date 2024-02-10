using System;

namespace ConsoleApp1
{
    internal class Class1
    {
        void Q1()
        {

            string answer;
            int result;
            Console.WriteLine("Enter first Number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second Number");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("A:Addition  B:Subsraction C:Division D:Multiplication");
            answer = Console.ReadLine();

            if (answer == "A")
            {
                result = a + b;
            }
            else if (answer == "B")
            {
                result = a - b;
            }
            else if (answer == "C")
            {
                result = a / b;


            }
            else 
            {
                result = a * b;

            }
            Console.WriteLine("Your answer is" + result);


        }
        void Q2()
        {
            Console.WriteLine("Even and odd numbers between the given range");

            Console.WriteLine("Enter the start range");
            int start=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the End range");
            int end=Convert.ToInt32(Console.ReadLine());

            Console.Write("Even numbers: ");
            for(int i =start;i<end ;i++ ) 
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("");
            Console.Write("Odd numbers: ");
            for (int i = start; i < end; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    
            void Q3()
        {
            int temp;
            Console.WriteLine("Enter the First number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number");
            int  b= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping: ");
            Console.WriteLine("First number:"+a);
            Console.WriteLine("Second number:"+b);

            temp = a;
            a = b;
            b = temp;


            Console.WriteLine("After swapping");
            Console.WriteLine("\nFist Number"+a+"\nSecond number"+b);

        }

            static void Main(string[] args)
            {
             Class1 p = new Class1();
            // p.Q1();
            //p.Q2();
            p.Q3();
             Console.ReadLine();
            }
       
    }
    
}


