using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYMNegocio
{
    public class AppData : List<AppData>
    {
        public DPFP.Template Template { get; set; }
        public int IDCliente { get; set; }
    }
}
