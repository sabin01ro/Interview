using Common.Entities;
using Common.Models;
using System.Collections.Generic;

namespace Common.Interfaces
{
    public interface IMapEmployeeToDataEmployee
    {
        List<EmployeeDataModel> MapEmployee(List<EmployeeModel> employees);
    }
}
