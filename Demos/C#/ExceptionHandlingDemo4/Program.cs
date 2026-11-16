
using System;
using System.IO;

class DataService
{
    public void LoadData()
    {
        try
        {
            string data = File.ReadAllText(
                "missing-file-12345.txt");

            Console.WriteLine(data);
        }
        catch (IOException ex)
        {
            throw new ApplicationException(
                "Unable to load application data.", ex);
        }
    }
}

class Program
{
    static void Main()
    {
        DataService service = new DataService();

        try
        {
            service.LoadData();
        }
        catch (ApplicationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");

            Console.WriteLine(
                $"Original Error: {ex.InnerException?.Message}");

            Console.WriteLine(
                $"Original Type: {ex.InnerException?.GetType().Name}");
        }
    }
}
