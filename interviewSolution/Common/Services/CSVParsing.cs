using Common.Interfaces;
using Common.Models;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Common.Services
{
    public class CSVParsing : ICSVParsing<EmployeeModel>
    {
        public List<EmployeeModel> CsvParse(StreamReader reader)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };

            using (var csv = new CsvReader(reader, config))
            {
                return csv.GetRecords<EmployeeModel>().ToList();
            }
        }
    }
}
