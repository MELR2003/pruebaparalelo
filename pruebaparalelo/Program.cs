using pruebaparalelo;
using static pruebaparalelo.Alumno;

Universidad miUniversidad = new Universidad();

Console.Write("Ingrese la cantidad de alumnos a agregar: ");
int cantidadAlumnos = int.Parse(Console.ReadLine());

for (int i = 0; i < cantidadAlumnos; i++)
{
    Console.WriteLine($"Ingrese los datos del alumno {i + 1}:");
    Console.Write("Nombre Completo: ");
    string nombre = Console.ReadLine();
    Console.Write("Edad: ");
    int edad = int.Parse(Console.ReadLine());
    Console.Write("Carrera Universitaria: ");
    string carreraStr = Console.ReadLine();
    Carreras carrera;
    Enum.TryParse(carreraStr, out carrera);
    Console.Write("Carnet: ");
    string carne = Console.ReadLine();

    Alumno nuevoAlumno = new Alumno(nombre, edad, carrera, carne);

    Console.WriteLine("Ingrese las calificaciones del alumno separadas por espacios:");
    string[] calificacionesStr = Console.ReadLine().Split(' ');
    List<double> calificaciones = new List<double>();
    foreach (string calificacionStr in calificacionesStr)
    {
        calificaciones.Add(double.Parse(calificacionStr));
    }
    nuevoAlumno.Calificaciones = calificaciones;

    miUniversidad.AgregarAlumno(nuevoAlumno);
}

List<Alumno> listaAlumnos = miUniversidad.ObtenerListaAlumnos();
foreach (Alumno alumno in listaAlumnos)
{
    Console.WriteLine("Nombre: " + alumno.Nombre);
    Console.WriteLine("Edad: " + alumno.Edad);
    Console.WriteLine("Carrera: " + alumno.Carrera);
    Console.WriteLine("Carnet: " + alumno.Carné);
    Console.WriteLine("Calificaciones: " + string.Join(", ", alumno.Calificaciones));
    Console.WriteLine("Promedio de Calificaciones: " + alumno.CalcularPromedioCalificaciones());
    Console.WriteLine("Estado de Aprobación: " + alumno.EstadoAprobacion());
    Console.WriteLine();
}
        
