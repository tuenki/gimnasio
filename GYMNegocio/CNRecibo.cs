using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYMDatos;

namespace GYMNegocio
{
    public class CNRecibo
    {
        private int _IDEmpleado;
        private int _IDCliente;
        private double _Pago;



        public int IDEmpleado { set { _IDEmpleado = value; } get { return _IDEmpleado; } }
        public int IDCliente { set { _IDCliente = value; } get { return _IDCliente; } }
        public double Pago { set { _Pago = value; } get { return _Pago; } }

        Recibo objRec = new Recibo();

        public void InsertarRecibo()
        {
            objRec.IDEmpleado = IDEmpleado;
            objRec.IDCliente = IDCliente;
            objRec.Pago = Pago;
            objRec.InsertarRecibo();
        }
    }
}
