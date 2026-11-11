namespace DemoOOP.Arithmetic
{
	public class Calc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c) // Overloaded method to add three integers
        {
            return a + b + c;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)a / b;
        }
    }
}
