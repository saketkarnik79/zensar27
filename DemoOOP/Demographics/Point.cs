namespace DemoOOP.Demographics
{
	internal struct Point
	{
		public int X { get; }
		public int Y { get; }

        public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

        public void Plot()
        {
            Console.WriteLine($"Plotting point at ({X}, {Y})");
        }
	}
}