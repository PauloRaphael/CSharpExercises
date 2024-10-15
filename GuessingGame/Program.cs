Random rand = new Random();

int numeroAleatorio = rand.Next(1, 100);

int tentativas = 0;

while (true)
{
    Console.Write("Digite um numero entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());
    tentativas++;

    if (chute < numeroAleatorio)
    {
        Console.WriteLine("Tente um numero maior.");

    }
    else if (chute > numeroAleatorio)
    {
        Console.WriteLine("Tente um numero menor");
    }
    else
    {
        Console.WriteLine("Parabens! você acertou o numero em {0} tentativas!", tentativas);
        Console.WriteLine("jogar de novo? ");
        char jogardenovo = char.Parse(Console.ReadLine());
        if (jogardenovo.Equals('y'))
        {
            Console.WriteLine("Reiniciando o jogo...");
            numeroAleatorio = rand.Next(1, 100);
            tentativas = 0;
        }
        else
        {
            break;
        }
    }
}
