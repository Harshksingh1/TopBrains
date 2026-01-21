class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
    public static void Main()
    {
         List<Student> students=new List<Student>(){
         new Student{Name="Harsh",Age=22,Marks=98},
         new Student{Name="Mohan",Age=23,Marks=98},
         new Student{Name="Sohan",Age=32,Marks=88}
         };
        var sortedStudents = students
                             .OrderByDescending(s => s.Marks)
                             .ThenBy(s => s.Age)
                             .ToList();
         foreach(var v in sortedStudents)
        {
            Console.WriteLine($"{v.Name}  {v.Age}  {v.Marks}");
        }                  

    }
}