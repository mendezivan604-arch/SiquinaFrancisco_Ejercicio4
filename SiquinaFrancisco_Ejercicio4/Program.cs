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

if (tipoIncidente < 1 || tipoIncidente > 4)
{
    Console.WriteLine("Tipo de incidente invalido");
}

if (activo < 1 || activo > 4)
{
    Console.WriteLine("Activo invalido");
}

if (datos < 1 || datos > 4)
{
    Console.WriteLine("Tipo de datos invalido");
}

if (usuarios < 0)
{
    Console.WriteLine("Numero de usuarios invalido");
}

switch (tipoIncidente)
{
    case 1: 
        switch (activo)
        {
            case 2:
                if (persistencia == "S")
                {
                    severidad = "Critica";
                    respuesta = "Aislar servidor y analizar malware";
                }
                else
                {
                    severidad = "Alta";
                    respuesta = "Escaneo completo y limpieza";
                }
                break;

            default:
                severidad = "Media";
                respuesta = "Escaneo antivirus";
                break;
        }
        break;

    case 2:
        if (usuarios > 10)
        {
            severidad = "Alta";
            respuesta = "Bloquear correos y advertir usuarios";
        }
        else
        {
            severidad = "Media";
            respuesta = "Capacitacion y cambio de contraseñas";
        }
        break;

    case 3:
        if (datos >= 3)
        {
            severidad = "Alta";
            respuesta = "Bloquear accesos y auditar sistema";
        }
        else
        {
            severidad = "Media";
            respuesta = "Revisar registros de acceso";
        }
        break;

    case 4:
        if (datos == 4)
        {
            severidad = "Critica";
            respuesta = "Notificar incidente y activar protocolo legal";
        }
        else
        {
            severidad = "Alta";
            respuesta = "Contener fuga y revisar permisos";
        }
        break;
}

if (usuarios < 5 && datos == 1)
{
    severidad = "Baja";
    respuesta = "Monitorear sistema";
}

Console.WriteLine("Severidad del incidente: " + severidad);
Console.WriteLine("Respuesta recomendada: " + respuesta);
