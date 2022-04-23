using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        { 
            int i, num1 = 0, flage = 0;  
            Console.Write("Enter a number: ");
            String input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            num1 = number/2;
            for(i = 2; i <= num1; i++) {
                if (number % i == 0) {
                    Console.WriteLine("Number is not prime");
                    flage = 1;
                    break;
                }
            }

            if (flage == 0)
                Console.WriteLine("number is prime.");

            

            Console.ReadLine();
        }
    }
}
