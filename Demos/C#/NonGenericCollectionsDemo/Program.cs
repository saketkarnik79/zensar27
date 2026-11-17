// Non-Generic Collection Types in C#
// 1. ArrayList
// 2. Hashtable
// 3. Queue
// 4. Stack
// 5. SortedList
// 6. BitArray

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        //ArrayListDemo();
        //HashTableDemo();
        // QueueDemo();
        //StackDemo();
        //SortedListDemo();
        BitArrayDemo();
    }

    private static void ArrayListDemo()    {
        // Step 1: Create ArrayList
        ArrayList employees = new ArrayList();

        // Step 2: Add employees
        employees.Add("Amit");
        employees.Add("Rahul");
        employees.Add("Priya");
        employees.Add("Neha");

        Console.WriteLine("Employee List:");

        foreach (object emp in employees)
        {
            Console.WriteLine(emp);
        }

        // Step 3: Insert employee
        employees.Insert(2, "Karan");

        Console.WriteLine("\nAfter Inserting Karan:");

        foreach (object emp in employees)
        {
            Console.WriteLine(emp);
        }

        // Step 4: Access element
        Console.WriteLine(
            "\nFirst Employee: " + employees[0]);

        // Step 5: Search employee
        bool exists = employees.Contains("Priya");

        Console.WriteLine(
            "Priya Exists: " + exists);

        // Step 6: Remove employee
        employees.Remove("Rahul");

        // Step 7: Remove using index
        employees.RemoveAt(0);

        Console.WriteLine("\nAfter Removing Employees:");

        foreach (object emp in employees)
        {
            Console.WriteLine(emp);
        }

        // Step 8: Sort
        employees.Sort();

        Console.WriteLine("\nSorted Employees:");

        foreach (object emp in employees)
        {
            Console.WriteLine(emp);
        }

        // Step 9: Reverse
        employees.Reverse();

        Console.WriteLine("\nReverse Order:");

        foreach (object emp in employees)
        {
            Console.WriteLine(emp);
        }

        // Step 10: Count
        Console.WriteLine(
            "\nTotal Employees: " + employees.Count);

        // Step 11: Capacity
        Console.WriteLine(
            "Capacity: " + employees.Capacity);
    }

    private static void HashTableDemo()
    {
        // Step 1: Create Hashtable
        Hashtable employees = new Hashtable();

        // Step 2: Add key-value pairs
        employees.Add(101, "Amit");
        employees.Add(102, "Rahul");
        employees.Add(103, "Priya");
        employees.Add(104, "Neha");

        Console.WriteLine("Employee Directory:");

        foreach (DictionaryEntry emp in employees)
        {
            Console.WriteLine(
                emp.Key + " - " + emp.Value);
        }

        // Step 3: Access employee
        Console.WriteLine(
            "\nEmployee 102: " + employees[102]);

        // Step 4: Check key
        if (employees.ContainsKey(103))
        {
            Console.WriteLine(
                "Employee ID 103 exists");
        }

        // Step 5: Check value
        if (employees.ContainsValue("Neha"))
        {
            Console.WriteLine(
                "Employee Neha exists");
        }

        // Step 6: Update employee
        employees[102] = "Rohit";

        // Step 7: Remove employee
        employees.Remove(101);

        Console.WriteLine("\nUpdated Employee Directory:");

        foreach (DictionaryEntry emp in employees)
        {
            Console.WriteLine(
                emp.Key + " - " + emp.Value);
        }

        // Step 8: Display keys
        Console.WriteLine("\nEmployee IDs:");

        foreach (object key in employees.Keys)
        {
            Console.WriteLine(key);
        }

        // Step 9: Display values
        Console.WriteLine("\nEmployee Names:");

        foreach (object value in employees.Values)
        {
            Console.WriteLine(value);
        }

        // Step 10: Count
        Console.WriteLine(
            "\nTotal Employees: " + employees.Count);
    }    

    private static void QueueDemo()
    {
        // Step 1: Create Queue
        Queue customers = new Queue();

        // Step 2: Add customers
        customers.Enqueue("Amit");
        customers.Enqueue("Rahul");
        customers.Enqueue("Priya");
        customers.Enqueue("Neha");

        Console.WriteLine("Waiting Customers:");

        foreach (object customer in customers)
        {
            Console.WriteLine(customer);
        }

        // Step 3: Check next customer
        Console.WriteLine(
            "\nNext Customer: " + customers.Peek());

        // Step 4: Serve customer
        Console.WriteLine(
            "\nServing: " + customers.Dequeue());

        // Step 5: Serve next customer
        Console.WriteLine(
            "Serving: " + customers.Dequeue());

        // Step 6: New customer arrives
        customers.Enqueue("Karan");

        // Step 7: Remaining customers
        Console.WriteLine("\nRemaining Customers:");

        foreach (object customer in customers)
        {
            Console.WriteLine(customer);
        }

        // Step 8: Count
        Console.WriteLine(
            "\nCustomers Waiting: " + customers.Count);
    }

    private static void StackDemo()
    {
        // Step 1: Create Stack
        Stack history = new Stack();

        // Step 2: Visit pages
        history.Push("Google");
        history.Push("YouTube");
        history.Push("GitHub");
        history.Push("Microsoft");

        Console.WriteLine("Browser History:");

        foreach (object page in history)
        {
            Console.WriteLine(page);
        }

        // Step 3: View current page
        Console.WriteLine(
            "\nCurrent Page: " + history.Peek());

        // Step 4: Go back
        Console.WriteLine(
            "\nGoing Back From: " + history.Pop());

        // Step 5: Current page
        Console.WriteLine(
            "Current Page: " + history.Peek());

        // Step 6: Go back again
        Console.WriteLine(
            "\nGoing Back From: " + history.Pop());

        // Step 7: Remaining history
        Console.WriteLine("\nRemaining History:");

        foreach (object page in history)
        {
            Console.WriteLine(page);
        }

        // Step 8: Count
        Console.WriteLine(
            "\nHistory Count: " + history.Count);
    }

    private static void SortedListDemo()
    {
        // Step 1: Create SortedList
        SortedList products = new SortedList();

        // Step 2: Add products
        products.Add(104, "Keyboard");
        products.Add(101, "Laptop");
        products.Add(103, "Mouse");
        products.Add(102, "Monitor");

        // Step 3: Display products
        Console.WriteLine("Sorted Product List:");

        foreach (DictionaryEntry product in products)
        {
            Console.WriteLine(
                product.Key + " - " + product.Value);
        }

        // Step 4: Access using key
        Console.WriteLine(
            "\nProduct 102: " + products[102]);

        // Step 5: Access by index
        Console.WriteLine(
            "First Product: " + products.GetByIndex(0));

        // Step 6: Get key by index
        Console.WriteLine(
            "First Product ID: " + products.GetKey(0));

        // Step 7: Update product
        products[103] = "Wireless Mouse";

        // Step 8: Remove product
        products.Remove(104);

        Console.WriteLine("\nUpdated Product List:");

        foreach (DictionaryEntry product in products)
        {
            Console.WriteLine(
                product.Key + " - " + product.Value);
        }

        // Step 9: Search
        Console.WriteLine(
            "\nContains Product 101: " +
            products.ContainsKey(101));

        // Step 10: Count
        Console.WriteLine(
            "Total Products: " + products.Count);
    }

    private static void BitArrayDemo()
    {
        // Step 1: Create permissions
        BitArray permissions = new BitArray(4);

        // Step 2: Assign permissions
        permissions[0] = true;   // Read
        permissions[1] = true;   // Write
        permissions[2] = false;  // Delete
        permissions[3] = true;   // Execute

        string[] names =
        {
            "Read",
            "Write",
            "Delete",
            "Execute"
        };

        // Step 3: Display permissions
        Console.WriteLine("User Permissions:");

        for (int i = 0; i < permissions.Length; i++)
        {
            Console.WriteLine(
                names[i] + ": " + permissions[i]);
        }

        // Step 4: Modify permission
        permissions[2] = true;

        Console.WriteLine(
            "\nDelete Permission Enabled: " +
            permissions[2]);

        // Step 5: Count bits
        Console.WriteLine(
            "\nTotal Permission Flags: " +
            permissions.Count);

        // Step 6: Set all permissions
        permissions.SetAll(false);

        Console.WriteLine("\nAfter Disabling All Permissions:");

        for (int i = 0; i < permissions.Length; i++)
        {
            Console.WriteLine(
                names[i] + ": " + permissions[i]);
        }
    }
}