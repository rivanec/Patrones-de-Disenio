using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Disenio
{
    public class Singleton
    {

        // Atributos
        private static Singleton instancia = null;
        public decimal Ventas;

        // C0nstructor
        protected Singleton()
        {
            // Inicializamos valores de atribustos
            Ventas = 0;
        }

        // Es una propiedad que que es una instancia de si misma
        //Solo se crea una vez
        public static Singleton Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new Singleton();
                return instancia;
            }
        }

    }
}
