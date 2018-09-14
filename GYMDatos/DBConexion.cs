using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GYMDatos
{
    class DBConexion
    {
        public static string NombreDB = "xtremegym";
        private SqlConnection Conexion = new SqlConnection("Server= NOVATO-PC\\SQLEXPRESS;Database=xtremegym;Integrated Security=true");
        //private SqlConnection Conexion = new SqlConnection("Server=XTREMEGYM\\SQLEXPRESS;Database=" + NombreDB + ";Integrated Security=true");
        //private SqlConnection Conexion = new SqlConnection(string.Format("Server=tcp:novato.database.windows.net,1433;Initial Catalog={0};Persist Security Info=False;User ID=gym;Password=helado@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;",NombreDB));
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if(Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
