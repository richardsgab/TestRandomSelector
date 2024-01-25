using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Student
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student()
        {
            Id = 0;
            Level = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        public override string ToString()
        {
            return $"{Id} - Level: {Level} - {FirstName} {LastName}";
        }
        public string FullInfo
        {
            get
            {
                return $"{Id} - {Level} - {FirstName} {LastName}";
            }
        }

    }

}
