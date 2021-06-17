using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Disenio
{
    public class FabricaTacos
    {
        // Constantes para evaluar que tipo de Producto se va a fabricar
        public const int carnitas = 1;
        public const int suadero = 2;
        public const int pastor = 3;

        //Metodo statico que se encarga de la fabricación del producto evaluando la propiedad tipo -- 1 = carnitas, 2 = suadero, 3 = pastor
        // devolviendo el tipo de dato Taco que hereda de PreparaTaco
        public static PreparaTaco FabricaTaco(int tipo)
        {


            switch (tipo)
            {
                case 1:
                    var taco = new TacoCarnitas();
                    return taco;
                case 2:
                    return new TacoSuadero();
                case 3:
                    return new TacoPastor();

                default:
                    return
                        null;
            }


        }
    }
}
