using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 

namespace ContosoUniversity.Models
{
    public class Instructor : Person // Herda de Person
    {
        // As propriedades ID, LastName, FirstName e FullName
        // são herdadas da classe base Person e NÃO DEVEM ser declaradas aqui.

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        public OfficeAssignment OfficeAssignment { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}