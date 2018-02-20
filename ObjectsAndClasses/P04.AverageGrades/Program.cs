using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            while (n-- > 0)
            {
                Student student = new Student();

                var studentInfo = Console.ReadLine().Split().ToList();
                var studentName = studentInfo[0];
                var grades = studentInfo.Skip(1).Select(double.Parse).ToList();

                student.Name = studentName;
                student.GradesList = grades;
                
                students.Add(student);
            }

            foreach (Student student in students.Where(s => s.Average >= 5.00).OrderBy(s => s.Name).ThenByDescending(s => s.Average))
            {
                Console.WriteLine("{0} -> {1:f2}",student.Name,student.Average);
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<double> GradesList { get; set; }

        public double Average => GradesList.Average();
    }
}
