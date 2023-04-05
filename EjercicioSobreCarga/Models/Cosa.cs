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

        public Cosa(DateTime fecha, int entero, string cadena):this(entero, cadena)
        {
            this.fecha = fecha;
        }
        public Cosa(int entero, string cadena):this(cadena)
        {
            this.entero = entero;
        }
        public Cosa(string cadena)
        {
            this.cadena = cadena;
        }
        public Cosa()
        {
            this.entero = 10;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
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
