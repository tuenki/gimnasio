using System;
using System.Data.SqlClient;
using System.Data;

namespace GYMDatos
{
    public class CDUsuario
    {
        private DBConexion Conexion = new DBConexion();
        private SqlDataReader Leer;
        private SqlCommand Comando = new SqlCommand();
        private DataTable Tabla = new DataTable();

        private String _Usuario;
        private String _Pass;
        private String _Nombre;
        private String _ApellidoP;
        private String _ApellidoM;
        private int _IDCliente;
        private int _IDUsuario;
        private int _Cargo;

        public int Cargo { set { _Cargo = value; }
            get { return _Cargo; }
        }

        public string Usuario
        {
            get{return _Usuario; }
            set{_Usuario = value;}
        }

        public string Pass
        {
            get{return _Pass;}
            set{_Pass = value;}
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string ApellidoP
        {
            get { return _ApellidoP; }
            set { _ApellidoP = value; }
        }
        public string ApellidoM
        {
            get { return _ApellidoM; }
            set { _ApellidoM = value; }
        }
        public int IDCliente
        {
            get { return _IDCliente; }
            set { _IDCliente = value; }
        }
        public int IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario= value; }
        }
        public SqlDataReader IniciarSesion()
        {
           
            Comando = new SqlCommand("SPIniciarSesion",Conexion.AbrirConexion());
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Usuario", Usuario);
            Comando.Parameters.AddWithValue("@Pass", Pass);
            Leer = Comando.ExecuteReader();
            return Leer;
        }
        public DataTable MostrarClientes()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarClientes";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            Leer.Close();
            Conexion.CerrarConexion();
            return Tabla;


        }
        public DataTable MostrarEmpleados()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarEmpleados";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            Leer.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListaUsuarios()
        {
            Comando = new SqlCommand("ListaDeUsuarios", Conexion.AbrirConexion());
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            Leer.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListaCargos()
        {
            Comando = new SqlCommand("ListaDeCargos", Conexion.AbrirConexion());
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Tabla.Load(Leer);
            Leer.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public void NuevoUsuario()
        {
            Comando = new SqlCommand("NuevoUsuario", Conexion.AbrirConexion());
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Nombre", Nombre);
            Comando.Parameters.AddWithValue("@ApellidoP", ApellidoP);
            Comando.Parameters.AddWithValue("@ApellidoM", ApellidoM);
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();

        }
        public void NuevoLogin()
        {
            Comando = new SqlCommand("NuevoLogin", Conexion.AbrirConexion());
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDUsuario", IDUsuario);
            Comando.Parameters.AddWithValue("@UserName", Usuario);
            Comando.Parameters.AddWithValue("@Pass", Pass);
            Comando.Parameters.AddWithValue("@Cargo", Cargo);
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();

        }
    }
}
