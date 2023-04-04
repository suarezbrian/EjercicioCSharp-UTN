using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I03.Models
{
    internal class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random rand;

        static Estudiante()
        {
            rand = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void GuardarPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void GuardarSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private float CalcularPromedio()
        {
            return (float)((this.notaPrimerParcial + this.notaSegundoParcial) / 2);
        }

        private int NotaFinal()
        {
            int notaFinal = -1;
            if (this.CalcularPromedio() > 4)
            {
                notaFinal  = Estudiante.rand.Next(6, 10);
            }
            return notaFinal;
        }

        public StringBuilder MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre {this.nombre}, Apellido {this.apellido}, Legajo {this.legajo}");
            sb.AppendLine($"Nota primer parcial : {this.notaPrimerParcial}, nota segundo parcial : {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio : {this.CalcularPromedio()}");

            if (this.NotaFinal() > 0)
            {
                sb.AppendLine($"Nota final : {this.NotaFinal()}");
            }
            else
            {
                sb.AppendLine($"Alumno desaprobado");
            }

            return sb;
        }
    }
}
