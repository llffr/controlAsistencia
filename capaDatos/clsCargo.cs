using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace capaDatos
{
    public class clsCargo : clsConexion
    {
        public void registrarCargo(string nom)
        {
            SqlCommand cmd = new SqlCommand("SP_registrarCargo", conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMCAR", nom);
            int rpt = cmd.ExecuteNonQuery();
            if (rpt >= 1)
            {

            }
        }

        // mostrar cargos - dbo.CARGO
        public DataTable listarCargo()
        {
            SqlCommand cmd = new SqlCommand("PA_LISTARCARGO", conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // eliminar cargo usando ID - dbo.CARGO
        public void eliminarCargo(int id)
        {
            SqlCommand cmd = new SqlCommand("eliminarCargo", conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@IDCARGO", id);
            cmd.Parameters.AddWithValue("@COD", id);
            cmd.ExecuteNonQuery();
        }
    }
}
