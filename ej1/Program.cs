int sumaP=0, sumaI=0;
Console.WriteLine("Ingrese los numeros que desea escepto negativos, [0] finaliza el programa");
int num = int.Parse(Console.ReadLine());
int i = 1;
if (num == 0) {
    i = 0;
}
while (i > 0) {
    Console.WriteLine("Ingrese el siguiente valor");
    num = int.Parse(Console.ReadLine());
    if (num == 0)
    {
        i = 0;
    }
    else {
        if (num < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Numero no registrado, vuelva a intentarlo");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else {
            if (num % 2 == 0)
            {
                sumaP += num;
            }
            else
            {
                sumaI += num;
            }
        }
    }
    
}
Console.WriteLine("Suma de los pares: "+sumaP);
Console.WriteLine("Suma de los impares: "+sumaI);

