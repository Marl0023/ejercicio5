string contra = "", contraV = "";
Console.Write("Registre su contraseña: ");
contra = Console.ReadLine();
Console.WriteLine("Contraseña registrada");
Console.WriteLine("Ingrese su contraseña: ");
contraV = Console.ReadLine();
if (contraV == contra)
{
    Console.WriteLine("Contraseña correcta");
}
else
{
    int contadorF = 1;
    while (contadorF < 3)
    {
        Console.WriteLine("Contraseña incorrenta, vuelva a intentarlo");
        contraV = Console.ReadLine();
        if (contraV == contra)
        {
            contadorF = 10;
        }
        else
            contadorF++;
    }
    if (contraV == contra)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Contraseña correcta \nBIENVENIDO");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Contraseña incorrecta, se quedo sin intentos");
        Console.ForegroundColor = ConsoleColor.White;
    }

}
