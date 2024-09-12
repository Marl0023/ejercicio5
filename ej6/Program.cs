Console.WriteLine("ingrese el numero de la tabla de multiplicar");
int num= int.Parse(Console.ReadLine());

if (num <= 0)
{
    while (num <= 0)
    {
        Console.WriteLine("Ingrese un numero diferente a 0 o negativo");
        num = int.Parse(Console.ReadLine());
    }

}

int i = 1;
while (true)
{
        
    Console.WriteLine($"{i}x{num}=" + (num * i));
    i++;
    if (i > 12)
        break;

}


