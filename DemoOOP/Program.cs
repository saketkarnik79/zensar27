using DemoOOP.Demographics;
using DemoOOP.Arithmetic;

namespace DemoOOP
{
	internal class Program
	{
        const double PI = 3.14159; // Constant declaration
        const int MonthsInYear = 12; // Constant declaration


		static void Main()
        {
            // Point point = new Point(3, 4);
            // point.Plot();
            // Person p1 = new Person(1, "Alice", 30);
            // Person p2 = new Person(2, "Bob", 25);
            // Person p3=p1;
            // p1.Display();
            // p2.Display();
            // p3.Display();

            // Console.WriteLine($"p1 and p3 are the same instance: {ReferenceEquals(p1, p3)}");
            // Console.WriteLine($"p1 and p2 are the same instance: {ReferenceEquals(p1, p2)}");
            // Console.WriteLine($"p2 and p3 are the same instance: {p2.Equals(p3)}");

            // Calc calc = new Calc();
            // int sum = calc.Add(5, 3);
            // int sum3 = calc.Add(5, 3, 2);
            // int difference = calc.Subtract(10, 4);
            // int product = calc.Multiply(6, 7);
            // double quotient = calc.Divide(20, 4);
            // Console.WriteLine($"Sum: {sum}");
            // Console.WriteLine($"Sum (3 args): {sum3}");
            // Console.WriteLine($"Difference: {difference}");
            // Console.WriteLine($"Product: {product}");
            // Console.WriteLine($"Quotient: {quotient}");

            Employee emp = new Employee(1, "Alice", 30, "HR", 50000);
            Console.WriteLine(emp.Display());

            // Person p=emp as Person;
            // Console.WriteLine(p.Display());

            // Console.WriteLine($"Value of PI: {PI}");
            // Console.WriteLine($"Months in a year: {MonthsInYear}");

            // double radius = 5.0;
            // double area = PI * radius * radius;
            // Console.WriteLine($"Area of a circle with radius {radius}: {area}");
        }
	}
}