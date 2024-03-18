using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmpleadoRepositoryArchivo : IEmpleadoRepository
    {
        private string _nombreArchivo;
        public EmpleadoRepositoryArchivo(string nombreArchivo)
        {
            _nombreArchivo = nombreArchivo;
        }
        public void GuardarTodo(List<Empleado> emps)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(_nombreArchivo))
                {
                    foreach (var emp in emps)
                    {
                        sw.WriteLine($"{emp.Nombre}, {emp.Edad}, {emp.Puesto}");
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine($"Error al escribir en el archivo: {ex.Message}");
            }
        }

        public List<Empleado> ObtenerTodo()
        {
            List<Empleado> ListEmp = new List<Empleado> ();
            try
            {
                using(StreamReader sr = new StreamReader(_nombreArchivo))
                {
                    string line;
                    while((line = sr.ReadLine()) != null) 
                    {
                        string[] datos = line.Split(',');
                        var emp = new Empleado()
                        {
                            Nombre = datos[0],
                            Edad = Convert.ToInt32(datos[1]),
                            Puesto = datos[2]
                        };
                        ListEmp.Add(emp);
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

            return ListEmp;
        }
    }
}
