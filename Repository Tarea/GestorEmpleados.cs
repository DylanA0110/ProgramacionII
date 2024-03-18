using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GestorEmpleados
    {
        private IEmpleadoRepository _respository;

        public GestorEmpleados(IEmpleadoRepository repository)
        {
            _respository = repository;
        }

        public List<Empleado> obtenerTodosLosEmpleados()
        {
            return _respository.ObtenerTodo();
        }

        public void AgregarEmpleado(Empleado emp)
        {
            List<Empleado> listEmp = _respository.ObtenerTodo();
            listEmp.Add(emp);
            _respository.GuardarTodo(listEmp);
        }
    }
}
