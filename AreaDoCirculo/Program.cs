double n, raio, area;

Console.WriteLine("Digite o valor do raio para calcular a área do círculo.");
n = 3.14159;
raio = double.Parse(Console.ReadLine());
area = n*(Math.Pow(raio, 2));

Console.WriteLine("A="+area.ToString("F4"));

