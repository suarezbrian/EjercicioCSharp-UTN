using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSobreCarga.Models
{
    internal class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public Cosa()
        {
            this.entero = 0;
            this.cadena = string.Empty;
            this.fecha = DateTime.MinValue;
        }
        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        private string Mostrar()
        {
            return $"Entero {this.entero}, Cadena {this.cadena}, Fecha {this.fecha}";           
        }

        public static string Mostrar(Cosa cosa)
        {
            return cosa.Mostrar(); 
        }
    }
}
