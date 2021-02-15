using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Common.Entities
{
    public partial class EmployeeDataModel
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [StringLength(10)]
        public string Title { get; set; }
        [Column("First_Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("Last_Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(10)]
        public string Sex { get; set; }
        [Column("Date_Of_Birth", TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [Column("Job_Title")]
        [StringLength(255)]
        public string JobTitle { get; set; }
        public double? Salary { get; set; }
    }
}
