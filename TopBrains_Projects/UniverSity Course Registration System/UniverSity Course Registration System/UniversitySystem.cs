using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            if (AvailableCourses.ContainsKey(code))
            {
                throw new ArgumentException($"Course code '{code}' already exists.");
            }

            var course = new Course(code, name, credits, maxCapacity, prerequisites);
            AvailableCourses.Add(code, course);
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            if (Students.ContainsKey(id))
            {
                throw new ArgumentException($"Student ID '{id}' already exists.");
            }

            var student = new Student(id, name, major, maxCredits, completedCourses);
            Students.Add(id, student);
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine($"Student with ID '{studentId}' not found.");
                return false;
            }

            if (!AvailableCourses.ContainsKey(courseCode))
            {
                Console.WriteLine($"Course with code '{courseCode}' not found.");
                return false;
            }

            var student = Students[studentId];
            var course = AvailableCourses[courseCode];

            return student.AddCourse(course);
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine($"Student with ID '{studentId}' not found.");
                return false;
            }

            var student = Students[studentId];
            return student.DropCourse(courseCode);
        }

        public void DisplayAllCourses()
        {
            Console.WriteLine("\n=== All Available Courses ===");
            foreach (var course in AvailableCourses.Values)
            {
                Console.WriteLine($"Code: {course.Code} | Name: {course.Name} | Credits: {course.Credits} | Enrolled: {course.EnrolledCount}/{course.MaxCapacity}");
            }
        }

        public void DisplayStudentSchedule(string studentId)
        {
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine($"Student with ID '{studentId}' not found.");
                return;
            }

            var student = Students[studentId];
            student.DisplaySchedule();
        }

        public void DisplaySystemSummary()
        {
            int totalStudents = Students.Count;
            int totalCourses = AvailableCourses.Count;
            double averageEnrollment = totalCourses > 0 ? AvailableCourses.Values.Average(c => c.EnrolledCount) : 0;

            Console.WriteLine("\n=== System Summary ===");
            Console.WriteLine($"Total Students: {totalStudents}");
            Console.WriteLine($"Total Courses: {totalCourses}");
            Console.WriteLine($"Average Enrollment per Course: {averageEnrollment:F2}");
        }
    }
}
