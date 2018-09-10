using System;
using System.Data.SqlClient;
using System.Data;


namespace GYMDatos
{
    public class CDMembresia
    {
        private DBConexion conexion = new DBConexion();
        SqlDataReader read;
        DataTable table = new DataTable();
        SqlCommand comand = new SqlCommand();

        private int _Id;
        private String _NameMembership;
        private int _Days;
        private int _IDType;
        private decimal _Price;

        public int ID
        {
            set { _Id = value; }
            get { return _Id; }
        }
        public String NameMembership
        {
            set { _NameMembership = value; }
            get { return _NameMembership; }
        }

        public int Days
        {
            set { _Days = value; }
            get { return _Days; }
        }

        public int IdType
        {
            set { _IDType = value; }
            get { return _IDType; }
        }

        public decimal Price
        {
            set { _Price = value; }
            get { return _Price; }
        }
        
        // mostrar membresias
        public DataTable ShowListMembership()
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "ListaMembresia";
            comand.CommandType = CommandType.StoredProcedure;
            read = comand.ExecuteReader();
            table.Load(read);
            read.Close();
            conexion.CerrarConexion();
            return table;
        }

        //mostrar tipos de membresia
        public DataTable ShowListTypeMembership()
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "ListaTipoMembresia";
            comand.CommandType = CommandType.StoredProcedure;
            read = comand.ExecuteReader();
            table.Load(read);
            read.Close();
            conexion.CerrarConexion();
            return table;
        }
        //nueva membresia
        public void NewMembership()
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "NuevaMembresia";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@NombreM", NameMembership);
            comand.Parameters.AddWithValue("@Duracioon", Days);
            comand.Parameters.AddWithValue("@IdT", IdType);
            comand.Parameters.AddWithValue("@precio", Price);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.CerrarConexion();

        }
        //editar membresia
        public void EditMembership()
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "editarMembresia";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@id", ID);
            comand.Parameters.AddWithValue("@nombre", NameMembership);
            comand.Parameters.AddWithValue("@duracion", Days);
            comand.Parameters.AddWithValue("@tipo", IdType);
            comand.Parameters.AddWithValue("@precio", Price);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.CerrarConexion();
        }
        //borrar membresia
        public void DeleteMembership()
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "EliminarMembresia";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@id", ID);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
