using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    //A propriedade Enrollments é uma propriedade de navegação. As propriedades de navegação armazenam outras entidades que estão relacionadas a essa entidade. A propriedade Enrollments de uma entidade Student:
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}