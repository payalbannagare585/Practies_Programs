using System;
//WRT program to find prime numbers between 1 to 100 
namespace PNFrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
              
            bool isPrime = true;
            int i, j;
             
            Console.WriteLine("Prime Numbers between 1 to 100  are : ");
            for (i = 2; i <= 100; i++)
            {
                for (j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("  " + i);
                }
                isPrime = true;
            }
            
        }
    }

}
  


