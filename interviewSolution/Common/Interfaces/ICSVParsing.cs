using System.Collections.Generic;
using System.IO;

namespace Common.Interfaces
{
    public interface ICSVParsing<T>
    {
         List<T> CsvParse(StreamReader reader);
    }
}
