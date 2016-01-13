using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    class Program
    {
        static int GetIntFromUser(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);

                    string input = Console.ReadLine();

                    int x = int.Parse(input);

                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Your input was not a valid number.");
                } 
            }
        }

        static void Main(string[] args)
        {
            int startingNumber = GetIntFromUser("Please input a number greater than 1.");
            int finalNumber = startingNumber;
            int largestNumber = 0;
            int n = 0;
            int largestN = n;
            
            for (n = 0; finalNumber != 1; n++)
                if (finalNumber % 2 == 0)
                {
                    finalNumber = finalNumber / 2;
                    if (finalNumber > largestNumber)
                    {
                        largestNumber = finalNumber;
                        largestN = n + 1;
                    }
                }
                else
                {
                    finalNumber = finalNumber * 3 + 1;
                    if (finalNumber > largestNumber)
                    {
                        largestNumber = finalNumber;
                        largestN = n + 1;
                    }
                }


            Console.WriteLine("It took " + n + " steps to reach 1 from " + startingNumber + ".");
            Console.WriteLine("The value reaches its peak of " + largestNumber + " at step " + largestN + ".");
            Console.WriteLine("Hit 'enter' to close.");
            Console.ReadLine();
        }
    }
}
