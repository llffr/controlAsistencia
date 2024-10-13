using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class clsConexion
    {
        protected SqlConnection conectar()
        {
            SqlConnection cnx = new SqlConnection
                (ConfigurationManager.ConnectionStrings["XCON"].ConnectionString);
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();

            }
            else
            {
                cnx.Open();
            }
            return cnx;
        }
    }
}
