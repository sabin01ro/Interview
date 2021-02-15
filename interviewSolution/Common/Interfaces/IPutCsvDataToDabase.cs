using System.IO;

namespace Common.Interfaces
{
    public interface IPutCsvDataToDabase
    {
        void PutCsvDataToDatabase(StreamReader reader);
    }
}
