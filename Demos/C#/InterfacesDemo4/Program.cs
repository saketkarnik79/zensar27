
using System;

interface IPrinter
{
    void Start();
}

interface IScanner
{
    void Start();
}

class MultiFunctionDevice : IPrinter, IScanner
{
    void IPrinter.Start() //Explicit interface implementation
    {
        Console.WriteLine("Printer Started");
    }

    void IScanner.Start() //Explicit interface implementation
    {
        Console.WriteLine("Scanner Started");
    }
}

class Program
{
    static void Main()
    {
        MultiFunctionDevice device =
            new MultiFunctionDevice();

        IPrinter printer = device;
        IScanner scanner = device;

        printer.Start();
        scanner.Start();
    }
}
