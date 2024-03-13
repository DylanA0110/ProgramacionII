using Repository;

//Empleado
string ficheroEmpleado = "empleados.txt";

IEmpleadoRepository empRepository = new EmpleadoRepositoryArchivo(ficheroEmpleado);

var gestorEmp = new GestorEmpleados(empRepository);

gestorEmp.AgregarEmpleado(new Empleado { Nombre = "Dylan", Edad = 18, Puesto = "Ingeniero de Sistemas" });
gestorEmp.AgregarEmpleado(new Empleado { Nombre = "Axel", Edad = 18, Puesto = "Programador" });
gestorEmp.AgregarEmpleado(new Empleado { Nombre = "Estrella", Edad = 18, Puesto = "Programador Frontend" });

    Console.WriteLine("| Todos los Empleados |\n");
foreach(var emp in gestorEmp.obtenerTodosLosEmpleados())
    Console.WriteLine($"Nombre: {emp.Nombre}, Edad: {emp.Edad}, Puesto: {emp.Puesto}");