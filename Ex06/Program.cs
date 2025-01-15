// Solicitar dois numeros ao usuario e realizr texto logico

Console.Write("N1");
double n1 = double.Parse
    (Console.ReadLine());


Console.Write("n2");
double n2 = double.Parse
    (Console.ReadLine());

Console.WriteLine($"N1 é maior que n2? RWaposta {n1 > n2}");
Console.WriteLine($"n1 é maior ou igual que n2? Resposta {n1 <= n2}");
Console.WriteLine($"n1 é menor que n2? Resposta {n1 <= n2}");
Console.WriteLine($"n1 é igual que n2? : Resposta {n1 == n2}");
Console.WriteLine($"n1 é diferente que n2? Resposta: {n1 != n2}");
Console.WriteLine($"n1 ou n2 são mairo que zero? Resposta: {(n1 > 0 || n2 > 0)}");
Console.WriteLine($"n1 e n2 são maior que zero? Resposta: {(n1 > 0 && n2 > 0)}");
