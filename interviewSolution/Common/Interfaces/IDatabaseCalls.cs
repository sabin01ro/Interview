using Common.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Common.Interfaces
{
    public interface IDatabaseCalls
    {
        EntityEntry AddEntity(EmployeeDataModel employee);
    }
}
