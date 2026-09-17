using System;

class Program
{
    static void Main()
    {
        string respuesta;

        do
        {
        Console.Clear();

        Console.WriteLine("Ejercios taller de programacion");
        Console.WriteLine("1. Positive Power");
        Console.WriteLine("2. Double or Triple");
        Console.WriteLine("3. Root or Square");
        Console.WriteLine("4. Circle Perimeter");
        Console.WriteLine("5. Midweek Day");
        Console.WriteLine("6. Tax Calculator");
        Console.WriteLine("7. Remainder Finder");
        Console.WriteLine("8. Sum of Evens");
        Console.WriteLine("9. Fraction Difference");
        Console.WriteLine("10. String Length");
        Console.WriteLine("11. Average of Four");
        Console.WriteLine("12. Smallest of Five");
        Console.WriteLine("13. Vowel Counter");
        Console.WriteLine("14. Factorial Finder");
        Console.WriteLine("15. InRange Validator");

        Console.Write("\nSeleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1: PositivePower(); break;
            case 2: DoubleOrTriple(); break;
            case 3: RootOrSquare(); break;
            case 4: CirclePerimeter(); break;
            case 5: MidweekDay(); break;
            case 6: TaxCalculator(); break;
            case 7: RemainderFinder(); break;
            case 8: SumOfEvens(); break;
            case 9: FractionDifference(); break;
            case 10: StringLength(); break;
            case 11: AverageOfFour(); break;
            case 12: SmallestOfFive(); break;
            case 13: VowelCounter(); break;
            case 14: FactorialFinder(); break;
            case 15: InRangeValidator(); break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
        Console.WriteLine("\n--------------------------------");
        Console.Write("¿Desea realizar otro ejercicio? (S/N): ");
        respuesta = Console.ReadLine().ToUpper();

    } while (respuesta == "S");
Console.WriteLine("\nGracias por usar el programa.");
    }

    // EJERCICIO 1
    static void PositivePower()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
            Console.WriteLine($"Resultado: {numero * numero}");
        else if (numero == 0)
            Console.WriteLine("Resultado: 0");
        else
            Console.WriteLine("Número negativo");
    }

    // EJERCICIO 2
    static void DoubleOrTriple()
    {
        Console.Write("Primer número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Segundo número: ");
        int b = int.Parse(Console.ReadLine());

        if (a >= b)
            Console.WriteLine($"Resultado: {a * 2}");
        else
            Console.WriteLine($"Resultado: {b * 3}");
    }

    // EJERCICIO 3
    static void RootOrSquare()
    {
        Console.Write("Ingrese un número: ");
        double numero = double.Parse(Console.ReadLine());

        if (numero > 0)
            Console.WriteLine($"Resultado: {Math.Sqrt(numero)}");
        else
            Console.WriteLine($"Resultado: {numero * numero}");
    }

    // EJERCICIO 4
    static void CirclePerimeter()
    {
        Console.Write("Ingrese el radio: ");
        double radio = double.Parse(Console.ReadLine());

        double perimetro = 2 * Math.PI * radio;

        Console.WriteLine($"Perímetro: {perimetro:F2}");
    }

    // EJERCICIO 5
    static void MidweekDay()
    {
        Console.Write("Ingrese un número del 1 al 7: ");
        int dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            default:
                Console.WriteLine("Número fuera del rango laboral");
                break;
        }
    }

    // EJERCICIO 6
    static void TaxCalculator()
    {
        Console.Write("Ingrese salario anual: ");
        double salario = double.Parse(Console.ReadLine());

        if (salario > 12000)
        {
            double impuesto = (salario - 12000) * 0.15;
            Console.WriteLine($"Impuesto a pagar: {impuesto}");
        }
        else
        {
            Console.WriteLine("No debe impuestos");
        }
    }

    // EJERCICIO 7
    static void RemainderFinder()
    {
        Console.Write("Primer número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Segundo número: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Residuo: {a % b}");
    }

    // EJERCICIO 8
    static void SumOfEvens()
    {
        int suma = 0;

        for (int i = 2; i <= 50; i += 2)
        {
            suma += i;
        }

        Console.WriteLine($"Resultado: {suma}");
    }

    // EJERCICIO 9
    static void FractionDifference()
    {
        Console.Write("Numerador 1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Denominador 1: ");
        int d1 = int.Parse(Console.ReadLine());

        Console.Write("Numerador 2: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.Write("Denominador 2: ");
        int d2 = int.Parse(Console.ReadLine());

        double resultado = ((double)n1 / d1) - ((double)n2 / d2);

        Console.WriteLine($"Resultado: {resultado}");
    }

    // EJERCICIO 10
    static void StringLength()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        Console.WriteLine($"Longitud: {palabra.Length}");
    }

    // EJERCICIO 11
    static void AverageOfFour()
    {
        double suma = 0;

        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"Número {i}: ");
            suma += double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Promedio: {suma / 4}");
    }

    // EJERCICIO 12
    static void SmallestOfFive()
    {
        Console.Write("Número 1: ");
        int menor = int.Parse(Console.ReadLine());

        for (int i = 2; i <= 5; i++)
        {
            Console.Write($"Número {i}: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < menor)
                menor = numero;
        }

        Console.WriteLine($"El menor es: {menor}");
    }

    // EJERCICIO 13
    static void VowelCounter()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        int contador = 0;

        foreach (char letra in palabra)
        {
            if ("aeiouáéíóú".Contains(letra))
                contador++;
        }

        Console.WriteLine($"Cantidad de vocales: {contador}");
    }

    // EJERCICIO 14
    static void FactorialFinder()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial: {factorial}");
    }

    // EJERCICIO 15
    static void InRangeValidator()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 10 && numero <= 20)
            Console.WriteLine("Está en el rango");
        else
            Console.WriteLine("Fuera del rango");
    }
}