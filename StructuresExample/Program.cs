using System;

class Program
{
    struct Student
    {
        public int StudentID;
        public string Name;
        public int Age;
        public float[] Grades;
    }

    static void doApp()
    {
        // Your struct-related code goes here
        // This method will store and display student details
        Student student;

        Console.Write("Enter Student ID: ");
        student.StudentID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter Age: ");
        student.Age = Convert.ToInt32(Console.ReadLine());

        student.Grades = new float[5];
        Console.Write("Enter Grades (5 subjects): ");
        for (int i = 0; i < 5; ++i)
        {
            student.Grades[i] = Convert.ToSingle(Console.ReadLine());
        }

        // Displaying student details
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine($"Student ID: {student.StudentID}");
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Age: {student.Age}");
        Console.Write("Grades: ");
        foreach (var grade in student.Grades)
        {
            Console.Write($"{grade} ");
        }
        Console.WriteLine("\n");
    }

    static void Main()
    {
        // Call your method here
        doApp();
    }
}
