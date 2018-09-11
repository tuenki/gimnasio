using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GYMDatos
{
    public class CDCaja
    {

        private int _RegistroCaja;
        private int _IDUsuario;
        private double _DineroInicial;
        private double _DineroFinal;
        private DateTime _FechaInicial;
        private DateTime _FechaFinal;

        public int RegistroCaja { set { _RegistroCaja = value; } get { return _RegistroCaja; } }
        public int IDUsuario { set { _IDUsuario = value; } get { return _IDUsuario; } }
        public double DineroInicial { set { _DineroInicial = value; } get { return _DineroInicial; } }
        public double DineroFinal { set { _DineroFinal = value; } get { return _DineroFinal; } }
        public DateTime FechaInicial { set { _FechaInicial = value; } get { return _FechaInicial; } }
        public DateTime FechaFinal { set { _FechaFinal = value; } get { return _FechaFinal; } }

        DBConexion Conexion = new DBConexion();
        SqlCommand Comando = new SqlCommand();

        public void CierreCaja()
        {
            Comando = new SqlCommand("CierreCaja", Conexion.AbrirConexion());
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDUsuario", IDUsuario);
            Comando.Parameters.AddWithValue("@DineroInicial", DineroInicial);
            Comando.Parameters.AddWithValue("@FechaInicial",_FechaInicial);
            Comando.Parameters.AddWithValue("@DineroFinal", _DineroFinal);
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();

        }
    }
}
