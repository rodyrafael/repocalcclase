using calculadoraclase.Logica;

Calculadora calc = new();
Console.WriteLine("Ingrese el primer número: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Seleccione la operación: ");
Console.WriteLine("1. Sumar"); 
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");
int opcion = Convert.ToInt32(Console.ReadLine());
double resultado = 0;
switch (opcion)
{
    case 1:
        resultado = calc.Sumar(num1, num2);
        break;
}
Console.WriteLine($"El resultado es: {resultado}");