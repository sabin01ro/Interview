using Common.Entities;
using Common.Interfaces;
using Common.Models;
using System.Collections.Generic;

namespace Common.Mappings
{
    public class MapEmployeeToDataEmployee : IMapEmployeeToDataEmployee
    {
        public List<EmployeeDataModel> MapEmployee(List<EmployeeModel> employees)
        {
            List<EmployeeDataModel> employeesData = new List<EmployeeDataModel>();
            foreach (var employee in employees)
            {
                employeesData.Add(new EmployeeDataModel
                {
                    DateOfBirth = employee.Date_Of_Birth,
                    Email = employee.Email,
                    FirstName = employee.First_Name,
                    Id = employee.ID,
                    JobTitle = employee.Job_Title,
                    LastName = employee.Last_Name,
                    Salary = employee.Salary,
                    Sex = employee.Sex,
                    Title = employee.Title
                });
            }
            return employeesData;
        }
    }
}
