using Common.EfStructures;
using Common.Entities;
using Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace Common.Services
{
    public class DatabaseCalls : IDesignTimeDbContextFactory<InterviewDbContext>,IDatabaseCalls
    {
        private  IConfiguration configuration;
        private InterviewDbContext _context = null;
        public EntityEntry AddEntity(EmployeeDataModel employee)
        {
            ResetContext();
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return _context.ChangeTracker.Entries().First();
        }

        public InterviewDbContext CreateDbContext(string[] args)
        {
            configuration = GetConfig();
            var optionsBuilder = new DbContextOptionsBuilder<InterviewDbContext>();
            var connectionString = configuration.GetSection("DataConnection").Value;
            optionsBuilder.UseSqlServer(connectionString, sqlServerOptionsAction: options => options.EnableRetryOnFailure());
            return new InterviewDbContext(optionsBuilder.Options);
        }
        private void ResetContext()
        {
            _context = new DatabaseCalls().CreateDbContext(args:null);
        }
        private  IConfiguration GetConfig()
        {
            return new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        }
    }
}
