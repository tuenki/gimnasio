using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYMDatos;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
namespace GYMNegocio
{
    public class CNUsuario
    {
        //Encapsular
        private CDUsuario objDato = new CDUsuario();// Instancia a la capa de datos de empleado
        //Variables
        
        private String _Usuario;
        private String _Contrasenia;

        //
        private String _Nombre;
        private String _ApellidoP;
        private String _ApellidoM;
        private int _IDCliente;
        private int _IDUsuario;
        private int _Cargo;

        public int Cargo
        {
            set { _Cargo = value; }
            get { return _Cargo; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { if (string.IsNullOrEmpty(value)) { _Nombre = "Nombre vacio"; } else { _Nombre = value; } }
        }
        public string ApellidoP
        {
            get { return _ApellidoP; }
            set { if (string.IsNullOrEmpty(value)) { _ApellidoP = "Apellido paterno vacio"; } else { _ApellidoP = value; } }
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
            set { _IDUsuario = value; }
        }
        //
        public String Usuario
        {
            set { if (string.IsNullOrEmpty(value)){ _Usuario = "Usuario vacio"; }
                else{_Usuario = value;} }

            get { return _Usuario; }

        }
        public String Contrasenia
        {
            set { if (string.IsNullOrEmpty(value)) { _Usuario = "Clave vacia"; }
                else { _Contrasenia = value;} }
            get { return _Contrasenia; }
        }

        

        public CNUsuario() { }

        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Logear;
            objDato.Usuario = Usuario;
            EncriptarPass();
            objDato.Pass = Contrasenia;
            Logear = objDato.IniciarSesion();
            return Logear;
        } 
        public void NuevoUsuario()
        {
            objDato.Nombre = Nombre;
            objDato.ApellidoP = ApellidoP;
            objDato.ApellidoM = ApellidoM;
            objDato.NuevoUsuario();
        }
        public void NuevoLogin()
        {
            objDato.IDUsuario = IDUsuario;
            objDato.Usuario = Usuario;
            EncriptarPass();
            objDato.Pass = Contrasenia;
            objDato.Cargo = Cargo;
            objDato.NuevoLogin();

        }
        public void EncriptarPass()
        {
            var bytes = Encoding.UTF8.GetBytes(Contrasenia);
            using (SHA512 Sham = new SHA512Managed())
            { 
                Contrasenia = Convert.ToBase64String(bytes);
            }
            
        }

    }
}
