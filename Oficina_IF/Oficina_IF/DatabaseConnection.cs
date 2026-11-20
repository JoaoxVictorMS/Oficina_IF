using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace Oficina_IF
{
    internal static class DatabaseConnection
    {
        internal static string GetConnectionString()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["Oficina"];
            if (settings == null)
            {
                throw new ConfigurationErrorsException("A conexão 'Oficina' não está configurada no App.config.");
            }

            string password = Environment.GetEnvironmentVariable("OFICINA_DB_PASSWORD");
            if (string.IsNullOrEmpty(password))
            {
                throw new InvalidOperationException("Defina a variável de ambiente OFICINA_DB_PASSWORD antes de conectar ao MySQL.");
            }

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(settings.ConnectionString);
            builder.Password = password;
            return builder.ConnectionString;
        }
    }
}
