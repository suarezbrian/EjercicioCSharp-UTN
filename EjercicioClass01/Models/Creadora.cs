using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClass01.Models
{
    internal class Creadora
    {
        private static DateTime fechaCreacionPrimerObjeto;
        private static int contadorObjetosCreados;
        private DateTime fechaCreacion;

        static Creadora()
        {
            Creadora.fechaCreacionPrimerObjeto = DateTime.Now;
            Creadora.contadorObjetosCreados = 0;
        }

        public Creadora(DateTime fechaActual)
        {
            this.fechaCreacion = fechaActual;
            Creadora.contadorObjetosCreados += 1;
        }

        public int ObtenerCantidadObjetosCreados()
        {
            return Creadora.contadorObjetosCreados;
        }

        public string ObtenerDiferencia()
        {
            return $"Diferencia es de : {(TimeSpan)(this.fechaCreacion - Creadora.fechaCreacionPrimerObjeto)}";
        }
    }
}
