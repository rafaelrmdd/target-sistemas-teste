using solucoes.Solucao2;
using solucoes.Solucao3;
using solucoes.Solucao4;
using solucoes.Solucao5;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha a solução desejada (2-5): ");
        int solucaoDesejada = int.Parse(Console.ReadLine());

        switch (solucaoDesejada)
        {
            case 2:
                Console.Clear();
                Solucao2.ExecutarSolucao2();
                break;
            case 3:
                Console.Clear();
                Solucao3.ExecutarSolucao3();
                break;
            case 4:
                Console.Clear();
                Solucao4.ExecutarSolucao4();
                break;
            case 5:
                Console.Clear();
                Solucao5.ExecutarSolucao5();
                break;

        }
    }
}