using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaparalelo
{
    public partial class Alumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set;}
        public string Carné { get; set; }
        public Carreras Carrera { get; set;}
        public List<double> Calificaciones { get; set; }

        public Alumno(string nombre, int edad, Carreras carrera, string carne)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Carrera = carrera;
            this.Carné = carne;
            Calificaciones = new List<double>();
    }
        public enum Carreras
        {
            Ingenieria_de_Sistemas,
            Ingenieria_en_computacion,
            Telecomunicaciones,
            Ingenieria_electronica,
        }

        public double CalcularPromedioCalificaciones()
        {
            if (Calificaciones.Count == 0)
            {
                return 0;
            }
            double sumaCalificaciones = 0;
            foreach (var calificacion in Calificaciones)
            {
                sumaCalificaciones += calificacion;
            }
            return sumaCalificaciones / Calificaciones.Count;

        }
        public string EstadoAprobacion()
        {
            double promedio = CalcularPromedioCalificaciones();
            if (promedio >= 60)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }
    }

   


}
