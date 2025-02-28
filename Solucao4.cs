namespace solucoes.Solucao4;

public class Solucao4
{
    public static void ExecutarSolucao4()
    {
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        double total = sp + rj + mg + es + outros;

        Console.WriteLine("Faturamento Mensal:");
        Console.WriteLine("SP: " + sp);
        Console.WriteLine("RJ: " + rj);
        Console.WriteLine("MG: " + mg);
        Console.WriteLine("ES: " + es);
        Console.WriteLine("Outros: " + outros);
        Console.WriteLine();

        Console.WriteLine($"SP: {(sp / total) * 100:F2}%");
        Console.WriteLine($"RJ: {(rj / total) * 100:F2}%");
        Console.WriteLine($"MG: {(mg / total) * 100:F2}%");
        Console.WriteLine($"ES: {(es / total) * 100:F2}%");
        Console.WriteLine($"Outros: {(outros / total) * 100:F2}%");
    }
}