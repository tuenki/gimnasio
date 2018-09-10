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

        private String _NameMembership;
        private int _Days;
        private int _IDType;
        private decimal _Price;

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

        public DataTable ShowListMembership()
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "ListaMembresia";
            comand.CommandType = CommandType.StoredProcedure;
            read = comand.ExecuteReader();
            table.Load(read);
            conexion.CerrarConexion();
            return table;
        }

        public DataTable ShowListTypeMembership()
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "ListaTipoMembresia";
            comand.CommandType = CommandType.StoredProcedure;
            read = comand.ExecuteReader();
            table.Load(read);
            conexion.CerrarConexion();
            return table;
        }

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
            conexion.CerrarConexion();

        }
    }
}
