using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroAnuncio.Repositories
{
    public class DbConnection
    {
        public string ConnectionString { get; set; }

        public DbConnection()
        {
            ConnectionString = GetConnectionString();
        }

        private string GetConnectionString()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration.GetConnectionString("AnuncioContext");
        }
    }
}
