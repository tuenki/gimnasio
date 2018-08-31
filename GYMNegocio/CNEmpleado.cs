using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYMDatos;
using System.Data.SqlClient;
using System.Data;
namespace GYMNegocio
{
    public class CNEmpleado
    {
        //Encapsular
        private CDEmpleado objDato = new CDEmpleado();// Instancia a la capa de datos de empleado
        //Variables
        
        private String _Usuario;
        private String _Contrasenia;
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
        public CNEmpleado() { }

        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Logear;
            Logear = objDato.IniciarSesion(Usuario, Contrasenia);
            return Logear;
        } 


    }
}
