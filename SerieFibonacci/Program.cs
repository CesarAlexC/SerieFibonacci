
int ValorInicial;
int Cantidad;

Console.WriteLine("Ingrese el numero inicial ");
ValorInicial = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de veces que se sumara ");
Cantidad = int.Parse(Console.ReadLine());

for (int i = 1; i <= Cantidad ; i++)
{
    ValorInicial = ValorInicial + i;
    Console.WriteLine( "La serie de Fibonaaci es  " + ValorInicial);
}

