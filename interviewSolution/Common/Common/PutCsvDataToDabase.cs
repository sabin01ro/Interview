using Common.Interfaces;
using Common.Mappings;
using Common.Models;
using Common.Services;
using System.IO;

namespace Common.Common
{
    public class PutCsvDataToDabase: IPutCsvDataToDabase
    {
        ICSVParsing<EmployeeModel> _csvParsing = new CSVParsing();
        IDatabaseCalls _DatabaseCalls = new DatabaseCalls();
        IMapEmployeeToDataEmployee _map = new MapEmployeeToDataEmployee();
        public void PutCsvDataToDatabase(StreamReader reader)
        {
            var csvFile = _csvParsing.CsvParse(reader);
            var employees = _map.MapEmployee(csvFile);
            foreach (var employee in employees)
            {
                _DatabaseCalls.AddEntity(employee);

            }
        }
    }
}
