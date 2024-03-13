using Strategy;

ILectorArchivo lectorTexto = new LectorArchivoTexto();
ILectorArchivo lectorxml = new LeerArchivoXML();

ContextoLectorArchivo context = new ContextoLectorArchivo(lectorTexto);
string contenidoTexto = context.LeerArchivo("archivo.txt");
Console.WriteLine($"Contenido del txt: {contenidoTexto}");
context.EstablecerEstrategia(lectorxml);
string contenidoXML= context.LeerArchivo("archivoX.xml");
Console.WriteLine($"\nContenido del XML: \n{contenidoXML}");
