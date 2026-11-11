namespace DemoOOP.Demographics
{
	public class Employee: Person
    {
        public string Department { get; }
        public double Salary { get; }

        public Employee(int id, string name, int age, string department, double salary): base(id, name, age)
        {
            Department = department;
            Salary = salary;
        }

        public override string Display() // Override the Display method to include department and salary (Method overriding or Polymorphism)
        {
            return $"{base.Display()}, Department: {Department}, Salary: {Salary}";
        }
    }
}
