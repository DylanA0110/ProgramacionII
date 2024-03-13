using Decorator;

ILectorDatos lector = new LectorArchivo("archivo.txt");
ILectorDatos lectorDecorado = new DecoratorLogger(lector);

string datos = lectorDecorado.LeerDatos();
Console.WriteLine($"Contenido leido: {datos}");