namespace solucoes.Solucao3;

class Solucao3
{
    public static void ExecutarSolucao3()
    {
        // Dados de faturamento diário
        var faturamentoDiario = new List<Faturamento>
        {
            new Faturamento { Dia = 1, Valor = 22174.1664 },
            new Faturamento { Dia = 2, Valor = 24537.6698 },
            new Faturamento { Dia = 3, Valor = 26139.6134 },
            new Faturamento { Dia = 4, Valor = 0.0 },
            new Faturamento { Dia = 5, Valor = 0.0 },
            new Faturamento { Dia = 6, Valor = 26742.6612 },
            new Faturamento { Dia = 7, Valor = 0.0 },
            new Faturamento { Dia = 8, Valor = 42889.2258 },
            new Faturamento { Dia = 9, Valor = 46251.174 },
            new Faturamento { Dia = 10, Valor = 11191.4722 },
            new Faturamento { Dia = 11, Valor = 0.0 },
            new Faturamento { Dia = 12, Valor = 0.0 },
            new Faturamento { Dia = 13, Valor = 3847.4823 },
            new Faturamento { Dia = 14, Valor = 373.7838 },
            new Faturamento { Dia = 15, Valor = 2659.7563 },
            new Faturamento { Dia = 16, Valor = 48924.2448 },
            new Faturamento { Dia = 17, Valor = 18419.2614 },
            new Faturamento { Dia = 18, Valor = 0.0 },
            new Faturamento { Dia = 19, Valor = 0.0 },
            new Faturamento { Dia = 20, Valor = 35240.1826 },
            new Faturamento { Dia = 21, Valor = 43829.1667 },
            new Faturamento { Dia = 22, Valor = 18235.6852 },
            new Faturamento { Dia = 23, Valor = 4355.0662 },
            new Faturamento { Dia = 24, Valor = 13327.1025 },
            new Faturamento { Dia = 25, Valor = 0.0 },
            new Faturamento { Dia = 26, Valor = 0.0 },
            new Faturamento { Dia = 27, Valor = 25681.8318 },
            new Faturamento { Dia = 28, Valor = 1718.1221 },
            new Faturamento { Dia = 29, Valor = 13220.495 },
            new Faturamento { Dia = 30, Valor = 8414.61 }
        };

        var faturamentoValido = faturamentoDiario.Where(f => f.Valor > 0).ToList();

        double menorFaturamento = faturamentoValido.Min(f => f.Valor);
        double maiorFaturamento = faturamentoValido.Max(f => f.Valor);

        double mediaMensal = faturamentoValido.Average(f => f.Valor);

        int diasAcimaDaMedia = faturamentoValido.Count(f => f.Valor > mediaMensal);

        Console.WriteLine("Faturamentos:");
        Console.WriteLine("Dia | Valor");
        foreach(Faturamento faturamento in faturamentoDiario)
        {
            Console.WriteLine(faturamento.Dia + "   " + faturamento.Valor);
        }
        Console.WriteLine();

        Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}

class Faturamento
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}