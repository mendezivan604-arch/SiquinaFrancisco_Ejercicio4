int tipoIncidente;
int activo;
int datos;
int usuarios;

string persistencia;

string severidad = "Baja";
string respuesta = "Monitorear";

Console.WriteLine("Tipo de incidente:");
Console.WriteLine("1 Malware");
Console.WriteLine("2 Phishing");
Console.WriteLine("3 Acceso no autorizado");
Console.WriteLine("4 Fuga de informacion");
tipoIncidente = int.Parse(Console.ReadLine());

Console.WriteLine("Activo afectado:");
Console.WriteLine("1 PC");
Console.WriteLine("2 Servidor");
Console.WriteLine("3 Base de datos");
Console.WriteLine("4 Red");
activo = int.Parse(Console.ReadLine());

Console.WriteLine("Datos comprometidos:");
Console.WriteLine("1 Ninguno");
Console.WriteLine("2 Internos");
Console.WriteLine("3 Personales");
Console.WriteLine("4 Financieros");
datos = int.Parse(Console.ReadLine());

Console.Write("Persistencia detectada (S/N): ");
persistencia = Console.ReadLine();

Console.Write("Numero de usuarios afectados: ");
usuarios = int.Parse(Console.ReadLine());
