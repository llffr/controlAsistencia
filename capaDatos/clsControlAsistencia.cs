using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class clsControlAsistencia : clsConexion
    {
        public void registrarAsistenciaPersonal(String dni)
        {
                SqlCommand cmd = new SqlCommand("sp_registroAsistenciaPersonal", conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", dni);
                cmd.ExecuteNonQuery();
        }
        public DataTable filtrarDatosPersona(String dni)
        {
            SqlCommand cmd = new SqlCommand("pa_filtrarDatosPersonal", conectar());
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dni", dni);
            DataTable dt= new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
