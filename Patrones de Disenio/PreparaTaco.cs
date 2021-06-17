using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Disenio
{
    // Una clase abstracta que implemmente toda la logistica de las subclases
    public abstract class PreparaTaco
    {
        public abstract string TipodeCarne();
        public abstract TacoCarnitas GetTacoCarnitas();
    }
}
