using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class LeerArchivo : ISujetoObservado
    {
        private List<IObservador> _observadorList = new List<IObservador>();
        private string _rutaArchivo;

        public LeerArchivo(string rutaArchivo)
        {
            _rutaArchivo = rutaArchivo;
        }
        public void AgregarObservador(IObservador observador)
        {
            _observadorList.Add(observador);
        }

        public void EliminarObservador(IObservador observador)
        {
           _observadorList.Remove(observador);
        }

        public void NotificarObservadores()
        {
            string datos = LeerDatos();
            foreach (var observador in _observadorList) 
            {
                observador.Actualizar(datos);
            }
        }

        private string LeerDatos()
        {
            using(StreamReader st = new StreamReader(_rutaArchivo)) 
            {
                return st.ReadToEnd();
            }
        }
    }
}
