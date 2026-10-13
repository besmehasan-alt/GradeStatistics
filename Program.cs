
using System;

class Program
{
    static void Main()
    {
        int grade;
        int count = 0;
        int sum = 0;
        int highest = int.MinValue;
        int lowest = int.MaxValue;

        Console.WriteLine("Enter grades (-1 to stop):");

        while (true)
        {
            grade = Convert.ToInt32(Console.ReadLine());

            if (grade == -1)
                break;

            count++;
            sum += grade;

            if (grade > highest)
                highest = grade;

            if (grade < lowest)
                lowest = grade;
        }

        Console.WriteLine("Count: " + count);
        Console.WriteLine("Sum: " + sum);

        if (count > 0)
        {
            double average = (double)sum / count;

            Console.WriteLine("Average: " + average);
            Console.WriteLine("Highest: " + highest);
            Console.WriteLine("Lowest: " + lowest);
        }
        else
        {
            Console.WriteLine("No grades entered.");
        }
    }
}
