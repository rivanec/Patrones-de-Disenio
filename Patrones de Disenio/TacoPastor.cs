using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Disenio
{
    // Subclase que implemenete los metodos de la clase abstracta
    class TacoPastor : PreparaTaco
    {
        //Metodos de las clase abstracta, cada clase ejecuta sus propieas reglas de negocio
        public override TacoCarnitas GetTacoCarnitas()
        {
            throw new NotImplementedException();
        }


        public override string TipodeCarne()
        {
            return "Este taco lleva carne al pastor";
        }
    }
}
