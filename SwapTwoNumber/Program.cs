using System;

namespace SwapTwoNumber
{
     public  class Program
    {
        static void Main(string[] args)
        {
            //int a , b ;

            // Console.WriteLine("Before swap a= " + a + " b= " + b);

            // a = a * b;     
            // b = a / b;      
            //a = a / b;  

            // Console.Write("After swap a= " + a + " b= " + b);
            int a,b;
           
            Console.WriteLine("Enter the number a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number b:");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("before swap a= " +a + " b= " +b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("after swap b=" + b  +"b=" +b);



        }
    }
    }
    

