using System;

namespace EvenOdd
{
     public class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter The Number");
            num=int.Parse(Console.ReadLine());

            for(int i = 0; i < num/2; i++)
            {
                if(num%2==0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
        }
    }
}
