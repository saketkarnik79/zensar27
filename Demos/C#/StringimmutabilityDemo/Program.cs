using System;

class Program
{
    static void Main()
    {
        string name1 = "Amit";

        string name2 = name1;

        name2 = "Rahul";

        Console.WriteLine("Name1: " + name1);
        Console.WriteLine("Name2: " + name2);
    }
}