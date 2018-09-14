using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYMDatos;

namespace GYMNegocio
{
    public class Mantenimiento
    {
        private string _Direccion;
        private string _NameDB;

        public string Direccion { set { _Direccion = value; } get { return _Direccion; } }
        
        CDMantenimiento Mante = new CDMantenimiento();
        public void CrearRespaldo()
        {
            Mante.Direccion = Direccion;
            Mante.NameDB = "Base";
            Mante.CrearRespaldo();
        }
        public void SubirRespaldo()
        {
            Mante.Direccion = Direccion;
            Mante.NameDB = "Base";
            Mante.SubirRespaldo();
        }
    }
}
