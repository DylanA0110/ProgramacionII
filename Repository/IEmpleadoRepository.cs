using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IEmpleadoRepository
    {
        List<Empleado> ObtenerTodo();
        void GuardarTodo(List<Empleado> emps);
    }
}
