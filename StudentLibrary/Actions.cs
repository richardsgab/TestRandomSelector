using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Actions
    {
        // Populate a students list
        public List<Student> GetStudents()
        {
            var students = new List<Student>();
            students.Add(new Student
            {
                Id = 1,
                Level = 1,
                FirstName = "Jon",
                LastName = "Jon"
            });
            students.Add(new Student
            {
                Id = 2,
                Level = 1,
                FirstName = "Jack",
                LastName = "Delon"
            });
            students.Add(new Student
            {
                Id = 3,
                Level = 2,
                FirstName = "Mustafa",
                LastName = "Delon"
            });
            students.Add(new Student
            {
                Id = 4,
                Level = 3,
                FirstName = "Atilla",
                LastName = "Delon"
            });
            students.Add(new Student
            {
                Id = 5,
                Level = 2,
                FirstName = "Quinten",
                LastName = "Delon"
            });
            students.Add(new Student
            {
                Id = 6,
                Level = 1,
                FirstName = "Pearl",
                LastName = "Delon"
            });
            students.Add(new Student
            {
                Id = 7,
                Level = 3,
                FirstName = "kenan",
                LastName = "Delon"
            });
            students.Add(new Student
            {
                Id = 8,
                Level = 2,
                FirstName = "Benedict",
                LastName = "Delon"
            });
            students.Add(new Student
            {
                Id = 9,
                Level = 2,
                FirstName = "Manuel",
                LastName = "Delon"
            });
            students.Add(new Student
            {
                Id = 10,
                Level = 1,
                FirstName = "Ilse",
                LastName = "Delon"
            });
            students.Add(new Student
            {
                Id = 11,
                Level = 2,
                FirstName = "Cindy",
                LastName = "Delon"
            });
            students.Add(new Student
            {
                Id = 12,
                Level = 2,
                FirstName = "Ruud",
                LastName = "Delon"
            });
            return students;
        }

        public static void WriteToFile(List<Student> students, string path) //traer contenido de Listbooks hacia un file
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                for (int index = 0; index < students.Count; index++)
                {
                    sw.WriteLine(students[index].Id);
                    sw.WriteLine(students[index].Level);
                    sw.WriteLine(students[index].FirstName);
                    sw.WriteLine(students[index].LastName);                   
                }
            }
        }

        public static List<Student> ReadFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                List<Student> lines = new List<Student>();
                while (!sr.EndOfStream)
                {
                    Student stu = new Student();
                    stu.Id = Convert.ToInt32(sr.ReadLine());
                    stu.Level = Convert.ToInt32(sr.ReadLine());
                    stu.FirstName = sr.ReadLine();
                    stu.LastName = sr.ReadLine();
                    lines.Add(stu);
                }
                return lines;
            }
        }
    }
}
