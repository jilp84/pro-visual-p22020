using Dapper;
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
        public static List<Persona> GetPersonas() {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) {
                var output = cnn.Query<Persona>("SELECT * FROM Persona", new DynamicParameters());

                return output.ToList();

            }

        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
