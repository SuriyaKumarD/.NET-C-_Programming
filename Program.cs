using System;

class GreetingsApp
{
    static void Main()
    {
        Console.WriteLine("Enter your Name:");
        string userName = Console.ReadLine();

        GreetUser(userName);
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello,{name}! Welcome to the C#.");
    }

}