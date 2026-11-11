namespace DemoOOP.Demographics
{
	public class Person
	{
        private readonly int id;

		public int Id 
		{ 
			get 
			{ 
				return id; 
			} 
		}

		public string Name { get; }
		public int Age { get; }

		public Person(int id, string name, int age)
		{
			this.id = id;
			Name = name;
			Age = age;
		}

        public virtual string Display()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
	}
}
       