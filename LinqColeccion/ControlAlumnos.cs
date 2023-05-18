using LinqColeccion.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqColeccion
{
    internal class ControlAlumnos
    {
        List<Carrera> carreras = new List<Carrera>();
        List<Alumno> alumnos = new List<Alumno>();

        public ControlAlumnos()
        {
            carreras.Add(new Carrera {idCarrera = 1, nombre = "Ingeniería de Software" });
            carreras.Add(new Carrera {idCarrera = 2, nombre = "Redes y Servicios de Computo" });

            alumnos.Add(new Alumno { idAlumno = 1, nombre = "Juan Perez Sanchez", matricula = "s90032", promedio = 8.9, idCarrera = 1 });
            alumnos.Add(new Alumno { idAlumno = 2, nombre = "Maria Rodriguez Martinez", matricula = "s24832", promedio = 6.8, idCarrera = 2 });
            alumnos.Add(new Alumno { idAlumno = 3, nombre = "Jose Trellez Jimenez", matricula = "s23684", promedio = 9.9, idCarrera = 2 });

        }

        public void obtenerAlumnosPorCarrera(int idCarrera)
        {
            var resultado = from alumno in alumnos
                            join carrera in carreras on alumno.idCarrera equals carrera.idCarrera
                            where alumno.idCarrera == idCarrera
                            select new { Alumno = alumno, Carrera = carrera.nombre }; //objeto anonimo con propiedades de los dos objetos

            foreach (var item in resultado)
            {
                Console.WriteLine("Nombre de la Carrera: " + item.Carrera);
                item.Alumno.getDatosAlumno();
            }
        }

    }
}
