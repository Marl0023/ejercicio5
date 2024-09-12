using System.Security.Cryptography;

Console.WriteLine("Ingrese el valor de los lados: ");
Console.Write("Ancho: ");
int ancho= int.Parse(Console.ReadLine());
if (ancho <= 1) {
    int i = 1;
    while (i == 1)
    //{
        if (ancho <=1) { 
            Console.WriteLine("Ingrese un numero diferente a 0 , a la unidad y negativo");
            ancho = int.Parse(Console.ReadLine());
        } else
            i = 0;
    }
}
Console.Write("Alto: ");
int alto  = int.Parse(Console.ReadLine());
if (alto <= 1)
{
    int o = 1;
    while (o == 1)
    {
        if (alto <= 1)
        {
            Console.WriteLine("Ingrese un numero diferente a 0 , a la unidad y negativo");
            alto = int.Parse(Console.ReadLine());
        }
        else
            o = 0;
    }
}
int i1 = 0;
int o1 = 0;
while (o1 <alto) {
    i1 = 0;
    while (i1 < ancho)
    {
        Console.Write("* ");
        i1++;
    }
    Console.Write("\n");
    o1++;
} 
