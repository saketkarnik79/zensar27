// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] marks = { 75, 82, 90, 68, 88 };

//         Console.WriteLine("Student Marks:");

//         for (int i = 0; i < marks.Length; i++)
//         {
//             Console.WriteLine(
//                 $"Student {i + 1}: {marks[i]}"
//             );
//         }
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] marks = new int[5];

//         int total = 0;

//         for (int i = 0; i < marks.Length; i++)
//         {
//             Console.Write($"Enter marks for student {i + 1}: ");

//             marks[i] = Convert.ToInt32(Console.ReadLine());

//             total += marks[i];
//         }

//         double average = (double)total / marks.Length;

//         Console.WriteLine("\nStudent Marks:");

//         for (int i = 0; i < marks.Length; i++)
//         {
//             Console.WriteLine(marks[i]);
//         }

//         Console.WriteLine("Total Marks: " + total);
//         Console.WriteLine("Average Marks: " + average);
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = { 40, 10, 50, 20, 30 };

//         Console.WriteLine("Original Array:");
//         Console.WriteLine(string.Join(", ", numbers));

//         // Sort array
//         Array.Sort(numbers);

//         Console.WriteLine("Sorted Array:");
//         Console.WriteLine(string.Join(", ", numbers));

//         // Reverse array
//         Array.Reverse(numbers);

//         Console.WriteLine("Reversed Array:");
//         Console.WriteLine(string.Join(", ", numbers));

//         // Search
//         int index = Array.IndexOf(numbers, 30);

//         Console.WriteLine("Index of 30: " + index);

//         // Maximum and minimum
//         Console.WriteLine("Maximum: " + numbers[0]);
//         Console.WriteLine("Minimum: " + numbers[numbers.Length - 1]);
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] matrix =
//         {
//             { 10, 20, 30 },
//             { 40, 50, 60 },
//             { 70, 80, 90 }
//         };

//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }

//             Console.WriteLine();
//         }
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[][] scores = new int[3][];

//         scores[0] = new int[] { 80, 90 };
//         scores[1] = new int[] { 70, 85, 95 };
//         scores[2] = new int[] { 60, 75, 88, 92 };

//         for (int i = 0; i < scores.Length; i++)
//         {
//             Console.Write($"Student {i + 1}: ");

//             for (int j = 0; j < scores[i].Length; j++)
//             {
//                 Console.Write(scores[i][j] + " ");
//             }

//             Console.WriteLine();
//         }
//     }
// }

using System;

class Program
{
    static void Main()
    {
        string[] employees =
        {
            "Rahul",
            "Priya",
            "Amit",
            "Sneha"
        };

        foreach (string employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}