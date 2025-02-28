namespace solucoes.Solucao5;

class Solucao5
{
    public static void ExecutarSolucao5()
    {
        Console.Write("Digite uma string para inverter: ");
        string texto = Console.ReadLine();

        string textoInvertido = InverterString(texto);

        Console.WriteLine("String invertida: " + textoInvertido);
    }

    static string InverterString(string texto)
    {
        char[] caracteres = texto.ToCharArray();

        int inicio = 0;
        int fim = caracteres.Length - 1;

        while (inicio < fim)
        {
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

            inicio++;
            fim--;
        }

        return new string(caracteres);
    }
}