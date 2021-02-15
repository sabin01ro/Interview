using Common.Common;
using Common.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace InterviewConsole
{
    class Program
    {
        private static IConfiguration configuration;
        static void Main(string[] args)
        {
            configuration = GetConfig();
            StreamWriter log;
            IPutCsvDataToDabase putCsvDataToDabase = new PutCsvDataToDabase();
            if (!File.Exists(configuration.GetSection("LogFile").Value))
            {
                log = new StreamWriter(configuration.GetSection("LogFile").Value);
            }
            else
            {
                log = File.AppendText(configuration.GetSection("LogFile").Value);
            }         

            try
            {
                string path = configuration.GetSection("FilePath").Value;
                using (var reader = new StreamReader(path))
                {
                    putCsvDataToDabase.PutCsvDataToDatabase(reader);
                }
                Console.WriteLine("Data sent to the database succesfully");
            }
            catch (Exception ex)
            {
                log.WriteLine(DateTime.Now);
                log.WriteLine("Error file not saved: " + ex.Message);
                log.WriteLine();
            }
        }

        private static IConfiguration GetConfig()
        {
            return new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        }
    }
}
