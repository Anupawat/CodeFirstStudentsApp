using System;

namespace CodeFirstStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Create a new student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2000, 1, 1)
                };

                // Add the student to the context
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }

            Console.ReadLine(); // Wait for user input before closing
        }
    }
}

