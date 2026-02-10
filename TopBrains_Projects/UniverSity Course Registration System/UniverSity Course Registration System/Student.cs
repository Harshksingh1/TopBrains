using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Student Class
    // =========================
    public class Student
    {
        public string StudentId { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }
        public int MaxCredits { get; private set; }

        public List<string> CompletedCourses { get; private set; }
        public List<Course> RegisteredCourses { get; private set; }

        public Student(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            StudentId = id;
            Name = name;
            Major = major;
            MaxCredits = maxCredits;
            CompletedCourses = completedCourses ?? new List<string>();
            RegisteredCourses = new List<Course>();
        }

        public int GetTotalCredits()
        {
            // TODO: Return sum of credits of all RegisteredCourses
            int totalCredits=0;
            foreach(var course in RegisteredCourses)
            {
                totalCredits+=course.Credits;
            }
            return totalCredits;
        }

    public bool CanAddCourse(Course course)
    {
        // 1. Course should not already be registered
        foreach(var registeredCourse in RegisteredCourses)
        {
            if(registeredCourse.CourseCode==course.CourseCode)
                return false;
        }

        // 2. Total credits + course credits <= MaxCredits
        if (GetTotalCredits() + course.Credits > MaxCredits)
            return false;

        // 3. Course prerequisites must be satisfied
        if (course.Prerequisites != null && course.Prerequisites.Count > 0)
        {
            foreach (var prerequisite in course.Prerequisites)
            {
                if (!CompletedCourses.Contains(prerequisite))
                    return false;
            }
        }

        return true;
    }

        public bool AddCourse(Course course)
        {
            // 1. Call CanAddCourse
            if (!CanAddCourse(course))
                return false;

            // 2. Check course capacity
            if (course.EnrolledStudents >= course.Capacity)
                return false;

            // 3. Add course to RegisteredCourses
            RegisteredCourses.Add(course);

            // 4. Call course.EnrollStudent()
            course.EnrollStudent();

            return true;
        }

        public bool DropCourse(string courseCode)
        {
            // 1. Find course by code
            var course = RegisteredCourses.FirstOrDefault(c => c.CourseCode == courseCode);
            if (course == null)
                return false;

            // 2. Remove from RegisteredCourses
            RegisteredCourses.Remove(course);

            // 3. Call course.DropStudent()
            course.DropStudent();

            return true;
        }

        public void DisplaySchedule()
        {
            if (RegisteredCourses.Count == 0)
            {
                Console.WriteLine("No courses registered.");
                return;
            }

            Console.WriteLine($"Schedule for {Name}:");
            foreach (var course in RegisteredCourses)
            {
                Console.WriteLine($"{course.CourseCode} - {course.CourseName} ({course.Credits} credits)");
            }
        }
    }
}
