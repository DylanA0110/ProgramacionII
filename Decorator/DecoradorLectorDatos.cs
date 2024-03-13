using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class DecoradorLectorDatos : ILectorDatos
    {
        protected ILectorDatos _lectorDatos;

        public DecoradorLectorDatos(ILectorDatos lectorDatos)
        {
            _lectorDatos = lectorDatos;
        }

        public virtual string LeerDatos()
        {
            return _lectorDatos.LeerDatos();
        }
    }
}
