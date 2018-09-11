using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYMDatos;

namespace GYMNegocio
{
    public class CNCaja
    {
        private int _RegistroCaja;
        private int _IDUsuario;
        private double _DineroInicial;
        private double _DineroFinal;
        private DateTime _FechaInicial;
        private DateTime _FechaFinal;

        public int RegistroCaja { set { _RegistroCaja = value; } get { return _RegistroCaja; } }
        public int IDUsuario { set { _IDUsuario = value; } get { return _IDUsuario; } }
        public double DineroInicial { set { _DineroInicial = value; } get { return _DineroInicial; } }
        public double DineroFinal { set { _DineroFinal = value; } get { return _DineroFinal; } }
        public DateTime FechaInicial { set { _FechaInicial = value; } get { return _FechaInicial; } }
        public DateTime FechaFinal { set { _FechaFinal = value; } get { return _FechaFinal; } }

        CDCaja ObCa = new CDCaja();
        public void CierreCaja()
        {
            ObCa.DineroInicial = DineroInicial;
            ObCa.FechaInicial = FechaInicial;
            ObCa.DineroFinal = DineroFinal;
            ObCa.IDUsuario = IDUsuario;
            ObCa.CierreCaja();
        }
    }
}
