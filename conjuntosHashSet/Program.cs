using System.Collections.Generic;
using conjuntosHashSet.Entities;

class Program
{
    private static void Main(string[] args)
    {
        HashSet<Student> a = new HashSet<Student>();
        HashSet<Student> b = new HashSet<Student>();
        HashSet<Student> c = new HashSet<Student>();

        int cont;
        string[] courses = new string[] {"A","B","C"}; 
        
        foreach(string course in courses)
        {
            Console.Write($"How many students for course {course}? ");
            cont = int.Parse(Console.ReadLine());
            for(int i = 0; i < cont; i++)
            {
                Student student = new Student(int.Parse(Console.ReadLine()));
                if (course.Equals("A"))
                {
                    a.Add(student);
                } else if (course.Equals("B"))
                {
                    b.Add(student);
                } else if (course.Equals("C"))
                {
                    c.Add(student);
                }
            }

        }

        HashSet<Student> allStudents = new HashSet<Student>(a);

        allStudents.UnionWith(b);
        allStudents.UnionWith(c);

        Console.WriteLine("Total Students: " + allStudents.Count);

        
        



    }
}