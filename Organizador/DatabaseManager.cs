using Microsoft.Data.Sqlite;
using Organizador.Models;
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

        public static List<Invitado> ObtenerInvitadosPorMesa(int mesaId)
        {
            var lista = new List<Invitado>();
            using var connection = GetConnection(); // Usa tu método existente

            var cmd = connection.CreateCommand();
            // JOIN entre Asignaciones e Invitados para traer los nombres de esa mesa
            cmd.CommandText = @"SELECT i.Id, i.Nombre, i.Grupo 
                        FROM Asignaciones a
                        JOIN Invitados i ON a.InvitadoId = i.Id
                        WHERE a.MesaId = @mesaId";
            cmd.Parameters.AddWithValue("@mesaId", mesaId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Invitado
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Grupo = reader.IsDBNull(2) ? "" : reader.GetString(2)
                });
            }
            return lista;
        }

        public static void AjustarCantidadMesas(int cantidad)
        {
            using var connection = GetConnection();

            // cuántas hay
            var cmdCount = connection.CreateCommand();
            cmdCount.CommandText = "SELECT COUNT(*) FROM Mesas;";
            int actuales = Convert.ToInt32(cmdCount.ExecuteScalar());

            if (actuales == cantidad) return;

            if (actuales < cantidad)
            {
                // Insertar faltantes: crea mesas 1..N sin duplicar NumeroMesa (es UNIQUE)
                for (int num = actuales + 1; num <= cantidad; num++)
                {
                    var ins = connection.CreateCommand();
                    ins.CommandText = @"INSERT INTO Mesas (NumeroMesa, Capacidad, Tipo)
                                VALUES (@num, 8, 'Normal');";
                    ins.Parameters.AddWithValue("@num", num);
                    ins.ExecuteNonQuery();
                }
            }
            else
            {
                var del = connection.CreateCommand();
                del.CommandText = @"DELETE FROM Mesas
                            WHERE NumeroMesa > @max;";
                del.Parameters.AddWithValue("@max", cantidad);
                del.ExecuteNonQuery();
            }
        }

        public static void QuitarInvitadoDeMesa(int invitadoId)
        {
            using var connection = GetConnection();
            var cmd = connection.CreateCommand();
            // Eliminamos la relación, el invitado vuelve a estar "Disponible"
            cmd.CommandText = "DELETE FROM Asignaciones WHERE InvitadoId = @invId";
            cmd.Parameters.AddWithValue("@invId", invitadoId);
            cmd.ExecuteNonQuery();
        }


        public static List<Invitado> ObtenerInvitadosPendientes()
        {
            var invitados = new List<Invitado>();
            using var connection = GetConnection();

            var cmd = connection.CreateCommand();
            // Traemos solo los que NO están en la tabla Asignaciones
            cmd.CommandText = @"SELECT Id, Nombre, Telefono, Alergias, Grupo 
                        FROM Invitados 
                        WHERE Id NOT IN (SELECT InvitadoId FROM Asignaciones)
                        ORDER BY Nombre";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                invitados.Add(new Invitado
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Telefono = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    Alergias = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    Grupo = reader.IsDBNull(4) ? "" : reader.GetString(4)
                });
            }
            return invitados;
        }

        public static int ObtenerOcupacionActual(int mesaId)
        {
            using var connection = GetConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Asignaciones WHERE MesaId = @mesaId";
            cmd.Parameters.AddWithValue("@mesaId", mesaId);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static void AsignarInvitadoAMesa(int invitadoId, int mesaId)
        {
            using var connection = GetConnection();

            // 1) Verificar si el invitado ya tiene asignación
            var check = connection.CreateCommand();
            check.CommandText = "SELECT 1 FROM Asignaciones WHERE InvitadoId = @invId LIMIT 1;";
            check.Parameters.AddWithValue("@invId", invitadoId);

            var existe = check.ExecuteScalar() != null;

            // 2) Si existe, movemos (UPDATE). Si no existe, asignamos (INSERT).
            if (existe)
            {
                var update = connection.CreateCommand();
                update.CommandText = @"
            UPDATE Asignaciones
            SET MesaId = @mesaId
            WHERE InvitadoId = @invId;";
                update.Parameters.AddWithValue("@mesaId", mesaId);
                update.Parameters.AddWithValue("@invId", invitadoId);
                update.ExecuteNonQuery();
            }
            else
            {
                var insert = connection.CreateCommand();
                insert.CommandText = @"
            INSERT INTO Asignaciones (InvitadoId, MesaId)
            VALUES (@invId, @mesaId);";
                insert.Parameters.AddWithValue("@invId", invitadoId);
                insert.Parameters.AddWithValue("@mesaId", mesaId);
                insert.ExecuteNonQuery();
            }
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

        public static void AgregarInvitado(string nombre, string telefono, string alergias, string grupo)
        {
            using var conn = GetConnection();

            string sql = @"INSERT INTO Invitados (Nombre, Telefono, Alergias, Grupo)
                   VALUES (@nombre, @telefono, @alergias, @grupo)";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@telefono", (object)telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@alergias", (object)alergias ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@grupo", (object)grupo ?? DBNull.Value);

            cmd.ExecuteNonQuery();
        }

        private static string connectionString = "Data Source=./Data/eventos.db";

        public static List<Invitado> ObtenerInvitados()
        {
            List<Invitado> lista = new List<Invitado>();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Nombre, Telefono, Alergias, Grupo FROM Invitados";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Invitado
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Telefono = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            Alergias = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            Grupo = reader.IsDBNull(4) ? "" : reader.GetString(4)
                        });
                    }
                }
            }
            return lista;
        }

        public static void EliminarInvitado(int id)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM Invitados WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void ActualizarInvitado(int id, string nombre, string telefono, string alergias, string grupo)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
            UPDATE Invitados 
            SET Nombre = @nombre, 
                Telefono = @telefono, 
                Alergias = @alergias, 
                Grupo = @grupo 
            WHERE Id = @id";

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@alergias", alergias);
                command.Parameters.AddWithValue("@grupo", grupo);

                command.ExecuteNonQuery();
            }
        }

    }

}