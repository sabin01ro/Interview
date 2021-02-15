using CsvHelper.Configuration.Attributes;
using System;

namespace Common.Models
{
    public class EmployeeModel
    {
        [Ignore]
        public Guid ID { get; set; } = Guid.NewGuid();
        [Index(0)]
        public string Title { get; set; }
        [Index(1)]
        public string First_Name { get; set; }
        [Index(2)]
        public string Last_Name { get; set; }
        [Index(3)]
        public string Sex { get; set; }
        [Index(4)]
        public DateTime Date_Of_Birth { get; set; }
        [Index(5)]
        public string Email { get; set; }
        [Index(6)]
        public string Job_Title { get; set; }
        [Index(7)]
        public double? Salary { get; set; }
    }
}
