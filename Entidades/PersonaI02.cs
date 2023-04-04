using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonaI02
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public PersonaI02(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public void GuardarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string ObtenerNombre()
        {
            return this.nombre;
        }

        public void GuardarFechaNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public DateTime ObtenerFechaNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        private int CalcularEdad()
        {
            return DateTime.Now.Year - this.fechaDeNacimiento.Year;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre : {this.nombre}, Fecha de Nacimiento : {this.fechaDeNacimiento}, DNI: {this.dni}, Edad : {this.CalcularEdad()}");
        }

        public void MostrarSiEsMayor()
        {
            if(this.EsMayor())
            {
                Console.WriteLine($"{this.nombre} es mayor de edad.");
            }
            else
            {
                Console.WriteLine($"{this.nombre} es menor de edad.");
            }
        }

        public bool EsMayor()
        {
            if(this.CalcularEdad() > 18)
            {
                return true;
            }
            return false;
        }
    }
}
