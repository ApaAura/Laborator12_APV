using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator12_APV.Entities
{
    public class DataBaseContext :DbContext
    {
        private readonly string? _connectionString;
        public DataBaseContext()
        {
            Configurator configurator = new Configurator("appsettings.json");
            _connectionString = configurator.ConnectionString;
        }
        public DataBaseContext(string? connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opBuilder)
        {
            opBuilder.UseSqlServer(_connectionString);
        }
    }
}
