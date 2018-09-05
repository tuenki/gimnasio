using System.Data.SqlClient;
using System.Data;

namespace GYMDatos
{
    class DBConexion
    {
        private SqlConnection Conexion = new SqlConnection("Server= ESCRITORIO;Database=GYM;Integrated Security=true");
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
