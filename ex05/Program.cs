// calcular que receba 2 numeros e apresente + - * /
Console.WriteLine("informe o 1° número:");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("informe o 2° número:");
double num2 = double.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("soma : " + (num1 + num2));
Console.WriteLine("subtração : " + (num1 - num2));
Console.WriteLine("multiplicação : " + (num1 * num2));

if( num2 != 0)
{
    Console.WriteLine("divisão : " + (num1 / num2));
}
else
{
    Console.WriteLine("divisão por ZERO não permitida");
}
