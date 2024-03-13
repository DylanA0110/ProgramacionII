using Adapter;

ILectorDatos Lector = new LectorDatos();

Cliente client = new Cliente(Lector);

client.OPLectura();

StreamReader READER = new StreamReader("Archivo.txt");
ILectorDatos lector2 = new AdaptadorStreamReader(READER);
Cliente cliente2 = new Cliente(lector2);

cliente2.OPLectura();