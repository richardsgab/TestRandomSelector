using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentLibrary
{
    public class Actions
    {
        // Populate a students list
        public static List<Student> GetStudents()
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

        public static List<Student> GenerateGroup(List<Student> students, int members)
        {
            /*List<Student> studentsgroup = new List<Student>();
             for(int i = 0;i< students.Count;i++) 
             {
                 List<Student> levelOne = new List<Student>();
                 if (students[i].Level == 1)
                 {
                     levelOne.Add(students[i]);
                 }
                 else 
                 {
                     List<Student> otherlevels = new List<Student>();
                     otherlevels.Add(students[i]);
                 }
             }*/
            Random random = new Random();
            List<Student> studentsgroup = new List<Student>();
            while(students.Count > 0) 
            {
                for(int i = 0; i == members; i++) 
                {
                    if (students[i].Level == 1)
                    {
                        studentsgroup.Add((Student)students[i]);
                       /* break;*/
                    }
                    studentsgroup.Add((Student)students[i]);
                }
                
            }
            Console.WriteLine(studentsgroup);
            return studentsgroup;
        }

        //***************************************************************Dritan's:
        public static List<Student> GetAllStudents(string filePath)
        {
            var students = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                students.Add(new Student
                {
                    Id = int.Parse(parts[0]),
                    Level = int.Parse(parts[1]),
                    FirstName = parts[2],
                    LastName = parts[3]
                });
            }
            return students;
        }
        public static List<Student> GetRandomStudents(string filePath, int count)
        {
            var random = new Random();
            var students = GetAllStudents(filePath);
            return students.OrderBy(x => random.Next()).Take(count).ToList();
        }
        
    }
}
