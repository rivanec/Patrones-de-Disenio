using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Disenio
{
    class Program
    {
        static void Main(string[] args)
        {
             
            // Invocamos la fabrica de tacos mandando como parametro el tipo de Taco Desarrollo
            var mitaco = FabricaTacos.FabricaTaco(FabricaTacos.carnitas);
            Console.WriteLine(mitaco.GetTacoCarnitas().nombre);

            mitaco = (TacoPastor) FabricaTacos.FabricaTaco(FabricaTacos.pastor);
            Console.WriteLine(mitaco.TipodeCarne());
            
            mitaco = FabricaTacos.FabricaTaco(FabricaTacos.suadero);
            Console.WriteLine(mitaco.TipodeCarne());



            /////
            ///Singleton////
            ///
            Console.WriteLine(Singleton.Instancia.Ventas);




            Console.ReadLine();
        }
    }
}
