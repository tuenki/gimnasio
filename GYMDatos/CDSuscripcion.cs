using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace GYMDatos
{
    public class CDSuscripcion
    {
        DBConexion Conexion = new DBConexion();
        SqlCommand Comando = new SqlCommand();
        private SqlDataReader Leer;
        DataTable Tabla = new DataTable();

        private int _IDSuscripcion;
        private int _IDCliente;
        private int _IDMem;
        private int _Dias;
        private int _IDRegistro;


        
        public int IDSuscripcion { set { _IDSuscripcion = value;} get { return _IDSuscripcion; } }
        public int IDCliente { set { _IDCliente = value; } get { return _IDCliente; } }
        public int IDMem { set { _IDMem = value; } get { return _IDMem; } }
        public int Dias { set { _Dias = value; } get { return _Dias; } }
        public int IDRegistro { set { _IDRegistro = value; } get { return _IDRegistro; } }



        public void NuevaSuscripcion()
        {
            Comando = new SqlCommand("NewSuscrip", Conexion.AbrirConexion());
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDCliente",IDCliente);
            Comando.Parameters.AddWithValue("@IDMembrecia",IDMem);
            Comando.Parameters.AddWithValue("@FechaSuma",Dias);
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        public void RenovarSuscripcion()
        {
            Comando = new SqlCommand("RenovarSuscrip", Conexion.AbrirConexion());
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDSus", IDSuscripcion);
            Comando.Parameters.AddWithValue("@IDCliente", IDCliente);
            Comando.Parameters.AddWithValue("@IDMembrecia", IDMem);
            Comando.Parameters.AddWithValue("@FechaSuma", Dias);
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        public DataTable MostrarSuscripHoy()
        {
            Comando = new SqlCommand("MostrarRegistrosHoy", Conexion.AbrirConexion());
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            //if (Leer.HasRows)
            Tabla.Load(Leer);
            //else
            //  Tabla = null;
            Leer.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public void InsertaRegistroDiario()
        {
            Comando = new SqlCommand("InsertarRegistroDiario", Conexion.AbrirConexion());
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDcliente", IDCliente);
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        public void ActualizarHoraFin()
        {
            Comando = new SqlCommand("ActualizarRegistro", Conexion.AbrirConexion());
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDRegistro", IDRegistro);
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
    }
}
