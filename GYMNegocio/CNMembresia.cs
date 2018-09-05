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

        private String _NameMembership;
        private String _Days;
        private String _IDType;
        private String _Price;

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
                if (_IDType == "Semanal")
                    _IDType = "1";
                else if (_IDType == "Mensual")
                    _IDType = "2";
                else if (_IDType == "Anual")
                    _IDType = "3";
                else if (_IDType == "Dias")
                    _IDType = "6";
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


        public DataTable ShowMembership()
        {
            DataTable table = new DataTable();
            table = objectCD.ShowListMembership();
            return table;
        }
        public DataTable ShowTypeMembership()
        {
            DataTable table = new DataTable();
            table = objectCD.ShowListMembership();
            return table;
        }

        public void NewMembership()
        {
            objectCD.NameMembership = NameMembership;
            objectCD.Days = Convert.ToInt32(Days);
            objectCD.IdType = Convert.ToInt32(IdType);
            objectCD.Price = Convert.ToDecimal(Price);
            objectCD.NewMembership();
        }
    }
}
