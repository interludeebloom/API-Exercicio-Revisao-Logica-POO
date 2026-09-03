// Declaração de variáveis
int[] numeros = new int[10];
for (int i = 0; i < numeros.Length; i++) 
{
    Console.WriteLine($"Informe o {i + 1} número");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Vetor na ordem original");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"{numeros[i]}");
}
Console.WriteLine("");
Console.WriteLine($"Vetor na ordem inversa");
for (int i = 9; i >=0; i--)
{
    Console.WriteLine($"{numeros[i]}");
}