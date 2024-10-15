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
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dni", dni);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //consulta asistencia por DNI
        public DataTable consultaAsistenciaDNI(String dni)
        {
            SqlCommand cmd = new SqlCommand("pa_consultaAsistenciaDNI", conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dni", dni);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //consulta asistencia por fecha 
        public DataTable consultaAsistenciaFecha(DateTime f1, DateTime f2)
        {
            SqlCommand cmd = new SqlCommand("pa_consultasFecha", conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@F1", f1);
            cmd.Parameters.AddWithValue("@F2", f2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
