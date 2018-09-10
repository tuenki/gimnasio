using System;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using GYMDatos;

namespace GYMNegocio
{
    public class CNMembresia
    {
        private CDMembresia objectCD = new CDMembresia();

        private String _ID;
        private String _NameMembership;
        private String _Days;
        private String _IDType;
        private String _Price;

        public String ID
        {
            set { _ID = value; }
            get { return _ID; }
        }
        public String NameMembership
        {
            set { _NameMembership = value; }
            get { return _NameMembership; }
        }

        public String Days
        {
            set { _Days = value; }
            get { return _Days; }
        }

        public String IdType
        {
            set
            {
                _IDType = value;
            }
            get
            {   return _IDType;}
        }

        public String Price
        {
            set { _Price = value; }
            get { return _Price; }
        }

        //listado de membresia
        public DataTable ShowMembership()
        {
            CDMembresia objecto = new CDMembresia();
            DataTable table = new DataTable();
            table = objecto.ShowListMembership();
            return table;
        }
        //listado de tipos
        public DataTable ShowTypeMembership()
        {
            CDMembresia objectT = new CDMembresia();
            DataTable table = new DataTable();
            table = objectT.ShowListTypeMembership();
            return table;
        }
        //nueva membresia
        public void NewMembership()
        {
            objectCD.NameMembership = NameMembership;
            objectCD.Days = Convert.ToInt32(Days);
            objectCD.IdType = Convert.ToInt32(IdType);
            objectCD.Price = Convert.ToDecimal(Price);
            objectCD.NewMembership();
        }
        //editar membresia
        public void EditMembership()
        {
            objectCD.ID = Convert.ToInt32(ID);
            objectCD.NameMembership = NameMembership;
            objectCD.Days = Convert.ToInt32(Days);
            objectCD.IdType = Convert.ToInt32(IdType);
            objectCD.Price = Convert.ToDecimal(Price);
            objectCD.EditMembership(); 
        }
        //borrar membresia
        public void DeleteMembership()
        {
            objectCD.ID = Convert.ToInt32(ID);
            objectCD.DeleteMembership();
        }
    }
}
