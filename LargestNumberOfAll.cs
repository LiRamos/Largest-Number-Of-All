using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, give me one number at a time, and I'll tell you which one of those numbers is the largest number. First off, please tell me how many numbers you'll be entering.");
            int length = int.Parse(Console.ReadLine());
            int[] userArray = new int[length];
            Console.WriteLine("Cool, now begin entering your numbers, pressing your Enter button after each number.");
            int largestNumber = 0;
        for (int i = 0; i < length; i++) {
               userArray[i] =int.Parse( Console.ReadLine());
                if (userArray[i] > largestNumber) {
                    largestNumber = userArray[i];
                }
            }
            Console.WriteLine("Alright, in the end, the largest number in the group of numbers you gave me was {0}", largestNumber);
        }

    }
}
