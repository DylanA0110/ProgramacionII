using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DecoratorLogger : DecoradorLectorDatos
    {
        public DecoratorLogger(ILectorDatos lectorDatos) : base(lectorDatos)
        {
        }

        public override string LeerDatos()
        {
            Console.WriteLine("Registrando operacion de lectura...");
            return base.LeerDatos();
        }
    }
}
