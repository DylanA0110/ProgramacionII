using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class LectorArchivoTexto : ILectorArchivo
    {
        public string Leer(string ruta)
        {
            string contenido = "";

            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    contenido = sr.ReadToEnd();
                }
            }
            catch (IOException e) 
            {
                Console.WriteLine($"Error en leer el fichero: {e.Message}");
            }
           return contenido;
           
        }
    }
}
