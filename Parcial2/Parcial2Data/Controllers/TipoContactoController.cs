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
    public class TipoContactoController
    {

        public static List<TipoContacto> GetTipoContactos()
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TipoContacto>("SELECT * FROM TipoContacto;", new DynamicParameters());

                return output.ToList();

            }

        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
