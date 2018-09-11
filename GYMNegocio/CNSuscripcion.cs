using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GYMDatos;

namespace GYMNegocio
{
    public class CNSuscripcion
    {
        DataTable Tabla;
        private int _IDSuscripcion;
        private int _IDCliente;
        private int _IDMem;
        private int _Dias;
        private int _IDRegistro;
        CDSuscripcion OBJSus = new CDSuscripcion();
        public int IDSuscripcion { set { _IDSuscripcion = value; } get { return _IDSuscripcion; } }
        public int IDCliente { set { _IDCliente = value; } get { return _IDCliente; } }
        public int IDMem { set { _IDMem = value; } get { return _IDMem; } }
        public int Dias { set { _Dias = value; } get { return _Dias; } }

        public int IDRegistro { set { _IDRegistro = value; } get { return _IDRegistro; } }

        public void NuevaSuscrip()
        {
            OBJSus.IDCliente = IDCliente;
            OBJSus.IDMem = IDMem;
            OBJSus.Dias = Dias;
            OBJSus.NuevaSuscripcion();
        }
        public void RenovarSuscrip()
        {
            OBJSus.IDSuscripcion = IDSuscripcion;
            OBJSus.IDCliente = IDCliente;
            OBJSus.IDMem = IDMem;
            OBJSus.Dias = Dias;
            OBJSus.RenovarSuscripcion();
        }
        public DataTable MostrarSuscripHoy()
        {
            Tabla = OBJSus.MostrarSuscripHoy();
            return Tabla;
        }
        public void InsertaRegistroDiario()
        {
            OBJSus.IDCliente = IDCliente;
            OBJSus.InsertaRegistroDiario();
        }
        public void ActualizarHoraFin()
        {
            OBJSus.IDRegistro = IDRegistro;
            OBJSus.ActualizarHoraFin();
        }
    }
}
