﻿using Dapper;
using Parcial2Data.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Data.Controllers
{
    public class PersonasCrontroller
    {
        public static List<Persona> GetPersonas()
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Persona>("SELECT * FROM Persona", new DynamicParameters());

                return output.ToList();

            }

        }

        public static List<Persona> BuscarPersonas(string buscar)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Persona>(
                    "SELECT * FROM Persona WHERE (Nombres || ' ' || Apellidos) like '%' || @Buscar || '%'", 
                    new {Buscar = buscar } );

                return output.ToList();

            }

        }

        public static List<Contactos> GetContactos(int buscar)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Contactos>(
                    "SELECT " +
                    "    C.Id, " +
                    "    C.Descripcion, " +
                    "    P.Id PersonaId, " + 
                    "    P.Nombres || ' ' || P.Apellidos PersonaNombre, " +
                    "    T.Id TipoContactoId, " +
                    "    T.Descripcion TipoContactoNombre " +
                    "FROM Persona P, PersonaContacto C, TipoContacto T " +
                    "WHERE P.Id = C.PersonaId " +
                    "    AND C.TipoContactoId = T.Id " +
                    "    AND P.Id = @Buscar ", new { Buscar = buscar });

                return output.ToList();

            }

        }

        public static void InsertarPersona(Persona persona)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                string sql = "INSERT INTO Persona ( "
                            + "    Nombres, "
                            + "    Apellidos, "
                            + "    FechaNacimiento "
                            + ") "
                            + "VALUES( "
                            + "    @Nombres, "
                            + "    @Apellidos, "
                            + "    @FechaNacimiento "
                            + ")";

                cnn.Execute(sql, persona);
            }

        }

        public static void EditarPersona(Persona persona)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = "UPDATE Persona "
                            + " SET "
                            + "  Nombres = @Nombres, "
                            + "  Apellidos = @Apellidos, "
                            + "  FechaNacimiento = @FechaNacimiento "
                            + " WHERE Id = @Id ";
                cnn.Execute(sql, persona);
            }

        }

        public static void BorrarPersona(Persona persona)
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = "DELETE FROM Persona WHERE Id = @Id";

                cnn.Execute(sql, persona);
            }

        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
