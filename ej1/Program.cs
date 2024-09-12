int x = 1, sumaP = 0, sumaI = 0;
while (x != 0) { 
    Console.WriteLine("Ingrese un numero: ");
    x= int.Parse( Console.ReadLine() );
    if (x < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Numero no registrado, vuelva a intentarlo");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (x % 2 == 0)
    {
        sumaP += x;
    }
    else
    {
        sumaI += x;
    }
}
Console.WriteLine("\nSuma de pares: " + sumaP);
Console.WriteLine("Suma de impares: " + sumaI);