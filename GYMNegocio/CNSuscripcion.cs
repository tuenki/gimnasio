using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYMDatos;

namespace GYMNegocio
{
    public class CNSuscripcion
    {
        private int _IDSuscripcion;
        private int _IDCliente;
        private int _IDMem;
        private int _Dias;
        CDSuscripcion OBJSus = new CDSuscripcion();
        public int IDSuscripcion { set { _IDSuscripcion = value; } get { return _IDSuscripcion; } }
        public int IDCliente { set { _IDCliente = value; } get { return _IDCliente; } }
        public int IDMem { set { _IDMem = value; } get { return _IDMem; } }
        public int Dias { set { _Dias = value; } get { return _Dias; } }


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
    }
}
