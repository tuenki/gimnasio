using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GYMDatos
{
    public class CDMantenimiento
    {
        private string _Direccion;
        private string _NameDB;

        public string Direccion { set { _Direccion = value; } get { return _Direccion; } }
        public string NameDB { set { _NameDB = NombreDB; } get { return _NameDB; } }

        public static string NombreDB = "xtremegym";

        DBConexion Conexion = new DBConexion();


        public void CrearRespaldo()
        {
            SqlCommand Comando = new SqlCommand("Backupdb", Conexion.AbrirConexion());
            Comando.CommandType = CommandType.StoredProcedure;
            Direccion += @"\"+ DateTime.Now.ToString("dd-mm-yyyy") + ".bak"; 
            Comando.Parameters.AddWithValue("@Direccion", Direccion);
            Comando.Parameters.AddWithValue("@NameDB", NameDB);
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();

        }
        public void SubirRespaldo()
        {
            SqlCommand Comando = new SqlCommand(string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;USE master;RESTORE DATABASE [{0}] FROM DISK = '{1}' WITH REPLACE;", NombreDB,Direccion), Conexion.AbrirConexion());
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
    }
}
