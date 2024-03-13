using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class AdaptadorStreamReader : ILectorDatos
    {
        private StreamReader _reader;

        public AdaptadorStreamReader(StreamReader reader)
        {
            _reader = reader;
        }
        public string Leer()
        {
            return _reader.ReadLine();
        }
    }
}
