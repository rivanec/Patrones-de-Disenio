using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Disenio
{
    // Subclase que implemenete los metodos de la clase abstracta
    public class TacoCarnitas : PreparaTaco
    {
        // Propiedad de una subclase
        public string nombre { get; set; }

        //Metodos de las clase abstracta, cada clase ejecuta sus propieas reglas de negocio
        public override TacoCarnitas GetTacoCarnitas()
        {
            this.nombre = "El de carnitas";
            return this;
        }

        public override string TipodeCarne()
        {
            return "Este taco lleva carnitas de cerdo";
        }
    }
}
