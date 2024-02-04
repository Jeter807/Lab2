using System;

class Lab6cs
{
    static void Main(string[] args)
    {
        Console.Write("Enter value for 'a' and press enter: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value for 'b' and press enter: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Calculate and display the average of the two numbers
        double average = (a + b) / 2;
        Console.WriteLine($"The average of {a} and {b} is: {average}");

        // Ask the user for an additional number
        Console.Write("Enter an additional number: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Calculate and display the average of all three numbers
        double totalAverage = (a + b + c) / 3;
        Console.WriteLine($"The average of {a}, {b}, and {c} is: {totalAverage}");
    }
}

