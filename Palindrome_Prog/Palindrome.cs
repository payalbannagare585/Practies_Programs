using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP Number is Palindrome  or not program 
namespace Palindrome_Prog
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            int n, rem, sum = 0, temp;
              
          
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                rem = n % 10; 
                n = n / 10;    
                sum = sum * 10 + rem;
              
            }
            Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
            if (temp == sum)   
            {
                Console.WriteLine(" Number is Palindrome");
            }
            else
            {
                Console.WriteLine(" Number is not a palindrome");
            }
            Console.ReadLine();

        }
    }
}
