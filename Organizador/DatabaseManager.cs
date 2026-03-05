using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;

namespace Organizador
{
    public static class DatabaseManager
    {
        private static string dbPath = Path.Combine(AppContext.BaseDirectory, "Data", "eventos.db");

        private static SqliteConnection GetConnection()
        {
            var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            var pragma = connection.CreateCommand();
            pragma.CommandText = "PRAGMA foreign_keys = ON;";
            pragma.ExecuteNonQuery();

            return connection;
        }

        public static List<Mesa> ObtenerMesas()
        {
            var mesas = new List<Mesa>();

            using var connection = GetConnection();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Id, NumeroMesa, Capacidad, Tipo FROM Mesas ORDER BY NumeroMesa";

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                mesas.Add(new Mesa
                {
                    Id = reader.GetInt32(0),
                    NumeroMesa = reader.GetInt32(1),
                    Capacidad = reader.GetInt32(2),
                    Tipo = reader.IsDBNull(3) ? "" : reader.GetString(3)
                });
            }

            return mesas;
        }
    }
}