using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
     // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter course code: ");
                            string code = Console.ReadLine();
                            Console.Write("Enter course name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter max capacity: ");
                            int capacity = int.Parse(Console.ReadLine());
                            system.AddCourse(code, name, capacity);
                            Console.WriteLine("Course added successfully.");
                            break;

                        case "2":
                            Console.Write("Enter student ID: ");
                            string studentId = Console.ReadLine();
                            Console.Write("Enter student name: ");
                            string studentName = Console.ReadLine();
                            Console.Write("Enter major: ");
                            string major = Console.ReadLine();
                            Console.Write("Enter year: ");
                            int year = int.Parse(Console.ReadLine());
                            system.AddStudent(studentId, studentName, major, year, new List<string>());
                            Console.WriteLine("Student added successfully.");
                            break;

                        case "3":
                            Console.Write("Enter student ID: ");
                            studentId = Console.ReadLine();
                            Console.Write("Enter course code: ");
                            code = Console.ReadLine();
                            system.RegisterStudentForCourse(studentId, code);
                            Console.WriteLine("Student registered for course.");
                            break;

                        case "4":
                            Console.Write("Enter student ID: ");
                            studentId = Console.ReadLine();
                            Console.Write("Enter course code: ");
                            code = Console.ReadLine();
                            system.DropStudentFromCourse(studentId, code);
                            Console.WriteLine("Student dropped from course.");
                            break;

                        case "5":
                            system.DisplayAllCourses();
                            break;

                        case "6":
                            Console.Write("Enter student ID: ");
                            studentId = Console.ReadLine();
                            system.DisplayStudentSchedule(studentId);
                            break;

                        case "7":
                            system.DisplaySystemSummary();
                            break;

                        case "8":
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

