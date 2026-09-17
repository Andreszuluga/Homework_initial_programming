// Exercise one - Positive Power
Console.Write("Ingrese un número: ");

int numero = int.Parse(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("Resultado: " + (numero * numero));
}
else if (numero == 0)
{
    Console.WriteLine("Resultado: 0");
}
else
{
    Console.WriteLine("Número negativo");
}
