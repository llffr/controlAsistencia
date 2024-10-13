using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Net;
using System.Security.Cryptography;

namespace capaDatos
{
    public class clsPersonal : clsConexion
    {
        public DataTable llenarCargo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from CARGO", conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable listadoPersonal()
        {
            SqlDataAdapter da = new SqlDataAdapter("pa_listarPersonal", conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //muestra info de empleados y cargo.
        public void registrarPersonal(string dni, string nom, string ape, string tel, int carg)
        {
            SqlCommand cmd = new SqlCommand("sp_registrarPersonal", conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DNI", dni);
            cmd.Parameters.AddWithValue("@NOM", nom);
            cmd.Parameters.AddWithValue("@APE", ape);
            cmd.Parameters.AddWithValue("@TELE", tel);
            cmd.Parameters.AddWithValue("@IDCARGO", carg);
            cmd.ExecuteNonQuery();
        }

        //actualiza info del personal - dni no debe cambiar
        public void actualizarPersonal(string dni, string nom, string ape, string tel, int carg)
        {
            SqlCommand cmd = new SqlCommand("sp_actualizarPersonal", conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DNI", dni);
            cmd.Parameters.AddWithValue("@NOM", nom);
            cmd.Parameters.AddWithValue("@APE", ape);
            cmd.Parameters.AddWithValue("@TELE", tel);
            cmd.Parameters.AddWithValue("@IDCARGO", carg);
            cmd.ExecuteNonQuery();
        }
    }
}
