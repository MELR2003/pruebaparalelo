using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaparalelo
{
    public partial class Universidad
    {
        private List<Alumno> listaAlumnos;

        public Universidad()
        {
            listaAlumnos = new List<Alumno>();
        }
        public void AgregarAlumno(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }
        public List<Alumno> ObtenerListaAlumnos()
        {
            return listaAlumnos;
        }

    }
}
