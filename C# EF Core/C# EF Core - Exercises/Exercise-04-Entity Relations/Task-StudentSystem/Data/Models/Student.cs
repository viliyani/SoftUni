using System;
using System.Collections.Generic;

namespace StudentSystem.Data.Models
{
    public class Student
    {
        public Student()
        {
            StudentCourses = new HashSet<StudentCourse>();
            Homeworks = new HashSet<Homework>();
        }

        public int StudentId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; }

        public DateTime Birthday { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }

        public virtual ICollection<Homework> Homeworks { get; set; }
    }
}
