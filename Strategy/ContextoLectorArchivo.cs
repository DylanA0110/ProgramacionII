using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ContextoLectorArchivo
    {
        private ILectorArchivo _lectorArchivo;

        public ContextoLectorArchivo(ILectorArchivo lectorArchivo)
        {
            _lectorArchivo = lectorArchivo;
        }

        public void EstablecerEstrategia(ILectorArchivo archivo)
        {
            _lectorArchivo = archivo;
        }

        public string LeerArchivo(string ruta)
        {
            return _lectorArchivo.Leer(ruta);
        }




    }
}
