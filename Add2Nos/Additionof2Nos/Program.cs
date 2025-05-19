using System;
using System.Diagnostics.CodeAnalysis;

class Add2Nos
{

    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());
        int result = AdditionodInput(num1, num2);
        Console.WriteLine($"The sum of 2 numbers is: {result}");
    }

    static int AdditionodInput(int num1, int num2)
    {
        return num1 + num2;
    }
}