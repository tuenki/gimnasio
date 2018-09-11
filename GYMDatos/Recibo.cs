using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GYMDatos
{
    public class Recibo
    {

        DBConexion Conexion = new DBConexion();
        SqlCommand Comando = new SqlCommand();
        private int _IDEmpleado;
        private int _IDCliente;
        private double _Pago;

        

        public int IDEmpleado { set { _IDEmpleado = value; } get { return _IDEmpleado; } }
        public int IDCliente { set { _IDCliente = value; } get { return _IDCliente; } }
        public double Pago { set { _Pago = value; } get { return _Pago; } }

        public void InsertarRecibo()
        {
            Comando = new SqlCommand("InsertarRecibo", Conexion.AbrirConexion());
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDEmpleado", IDEmpleado);
            Comando.Parameters.AddWithValue("@IDCliente", IDCliente);
            Comando.Parameters.AddWithValue("@Pago", Pago);
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
        }
        
    }
}
