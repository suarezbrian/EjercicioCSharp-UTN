using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I04.Models
{
    internal class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor ObtenerColor()
        {
            return this.color;
        }

        public short ObtenerTinta()
        {
            return this.tinta;                 
        }

        private void GuardarTinta(short tinta)
        {
            if((this.tinta + tinta) >= 0 && (this.tinta + tinta) <= cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }

        public void RecargarTinta()
        {
            GuardarTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool esValido = false;
            if(gasto <= this.tinta)
            {
                esValido = true;
                this.tinta -= gasto;
                dibujo = $"* - gasto un total de {gasto} de tinta";
                return esValido;
            }

            dibujo = "Tinta Vacia";
            return esValido;
        }
    }
}
