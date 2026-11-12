
// using System;

// class Employee
// {
//     private int employeeId;
//     private string name = "";
//     private decimal salary;

//     // Read-only property
//     public int EmployeeId
//     {
//         get
//         {
//             return employeeId;
//         }
//         private set
//         {
//             employeeId = value;
//         }
//     }

//     // Read-write property
//     public string Name
//     {
//         get
//         {
//             return name;
//         }

//         set
//         {
//             if (!string.IsNullOrWhiteSpace(value))
//             {
//                 name = value;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid Employee Name");
//             }
//         }
//     }

//     // Property with validation
//     public decimal Salary
//     {
//         get
//         {
//             return salary;
//         }

//         set
//         {
//             if (value >= 0)
//             {
//                 salary = value;
//             }
//             else
//             {
//                 Console.WriteLine("Salary cannot be negative");
//             }
//         }
//     }

//     // Computed property
//     public decimal AnnualSalary
//     {
//         get
//         {
//             return salary * 12;
//         }
//     }

//     public Employee(int id, string name, decimal salary)
//     {
//         employeeId = id;
//         Name = name;
//         Salary = salary;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Employee emp = new Employee(101, "Amit", 50000);

//         Console.WriteLine("Employee ID: " + emp.EmployeeId);
//         Console.WriteLine("Employee Name: " + emp.Name);
//         Console.WriteLine("Monthly Salary: " + emp.Salary);
//         Console.WriteLine("Annual Salary: " + emp.AnnualSalary);

//         // Updating property
//         emp.Salary = 60000;

//         Console.WriteLine("Updated Salary: " + emp.Salary);

//         // Invalid salary
//         emp.Salary = -5000;

//         Console.WriteLine("Final Salary: " + emp.Salary);
//     }
// }



using System;

class Product
{
    // Auto-implemented properties
    public int ProductId { get; init; }

    public string ProductName { get; set; } = string.Empty;

    //public decimal Price { get; set; }
    private decimal price;
    public decimal Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value), "Price cannot be negative.");
            }
            price = value;
        }
    }

    // Private setter
    public int StockQuantity { get; private set; }

    // Property with default value
    public string Category { get; set; } = "General";

    // Constructor
    public Product(int stockQuantity)
    {
        if (stockQuantity < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(stockQuantity));
        }

        StockQuantity = stockQuantity;
    }

    // Method to update stock
    public void AddStock(int quantity)
    {
        if (quantity > 0)
        {
            StockQuantity += quantity;
        }
    }

    // Method to display product
    public void DisplayProduct()
    {
        Console.WriteLine("Product ID: " + ProductId);
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Stock: " + StockQuantity);
        Console.WriteLine("Category: " + Category);
    }
}

class Program
{
    static void Main()
    {
        Product product = new Product(20)
        {
            ProductId = 101,
            ProductName = "Laptop",
            Price = 55000,
            Category = "Electronics"
        };

        Console.WriteLine("Initial Product Details:");
        product.DisplayProduct();

        product.AddStock(10);

        Console.WriteLine("\nAfter Stock Update:");
        product.DisplayProduct();
    }
}
