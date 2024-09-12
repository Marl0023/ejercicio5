int uno=0, dos=0, tres=0, cuatro=0;
int sumaT;
int cont1=0, cont2=0, cont3=0, cont4=0;
int voto;
while (true) {
	Console.WriteLine("Ingrese su eleccion: [1 - 2 -3 - 4], [0] para terminar");
	voto = int.Parse(Console.ReadLine());
	if (voto == 0) {
		break;
	} else if (voto == 1) {
		cont1++;
	} else if (voto == 2) {
		cont2++;
	} else if (voto == 3) {
		cont3++;
	} else if (voto == 4) {
		cont4++;
	} else
		Console.WriteLine("Voto no especificado [1-2-3-4]");
}

sumaT = cont1 + cont2+ cont3+ cont4;
uno = ((cont1*100 )/ sumaT);
dos = ((cont2*100) / sumaT);
tres = ((cont3*100 / sumaT));
cuatro = ((cont4*100) / sumaT);
Console.WriteLine("Resultado: ");
Console.WriteLine($"UNO: {uno}%");
Console.WriteLine($"DOS: {dos}%");
Console.WriteLine($"TRES: {tres}%");
Console.WriteLine($"CUATRO: {cuatro}%");

