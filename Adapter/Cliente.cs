using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Cliente
    {
        private ILectorDatos _lector;

        public Cliente(ILectorDatos lector)
        {
            _lector = lector;
        }

        public void OPLectura()
        {
            string datos = _lector.Leer();
            Console.WriteLine($"Datos Leidos: {datos}");
        }
    }
}
