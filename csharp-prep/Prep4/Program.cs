using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        // Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> userNumbers = new List<int>();
        

        do
        {
            Console.Write("Enter number: ");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber == 0)
            {
                break;
            }
            userNumbers.Add(userNumber);
        } while (true);

        // Compute the sum, or total, of the numbers in the list.
        int totalNum = 0;
        foreach (int num in userNumbers)
        {
            totalNum += num;
        }
        Console.WriteLine($"The sum is: {totalNum}");

        // Compute the average of the numbers in the list.
        float userAverage = (float)totalNum / userNumbers.Count;
        Console.WriteLine($"The average is: {userAverage}");

        // Find the maximum, or largest, number in the list.
        int largestNum = userNumbers[0];
        foreach (int num in userNumbers)
        {
            if (num > largestNum)
            {
                largestNum = num;
            }
        }
        Console.WriteLine($"The largest number is: {largestNum}");

        // Have the user enter both positive and negative numbers, then find the smallest positive number (the positive number that is closest to zero).
        // int smallestPositive = 0;
        // // This loop is to extract the first positive number from the list to start with
        // foreach (int num in userNumbers)
        // {
        //     if (num > 0)
        //     {
        //         smallestPositive = num;
        //         break;
        //     }
        // }
        // // Now I run the loop again to find the smallest positive int.
        int smallestPositive = int.MaxValue;
        foreach (int num in userNumbers)
        {
            if (num < smallestPositive && num > 0)
            {
                smallestPositive = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sort the numbers in the list and display the new, sorted list.
        userNumbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in userNumbers)
        {
            Console.WriteLine(num);
        }





    }
}