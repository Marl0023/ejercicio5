int lista1, lista2, sumaLista1 = 0, sumaLista2 = 0;
Console.WriteLine("Ingrese los valores de la lista 1: ");
int i = 1;
while (i <= 10)
{
    Console.Write($"Ingrese el valor N° {i}: ");
    lista1=int.Parse( Console.ReadLine() );
    sumaLista1 += lista1;
    i++;
}
Console.WriteLine("Ingrese   los valores de la lista 2: ");
int o = 1;
while (o <= 10)
{
    Console.Write($"Ingrese el valor N° {o}: ");
    lista2 = int.Parse(Console.ReadLine());
    sumaLista2 += sumaLista2;
    o++;
}
if (sumaLista1 == sumaLista2)
{
    Console.WriteLine("listas iguales");
}
else if (sumaLista1 > sumaLista2)
{
    Console.WriteLine("La lista 1 es la mayor de las dos");
}
else
    Console.WriteLine("La lista 2 es la mayor de las dos)");