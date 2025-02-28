namespace solucoes.Solucao2;

class Solucao2
{
    public static void ExecutarSolucao2()
    {
        Console.Write("Digite um n�mero para verificar na sequ�ncia de Fibonacci: ");
        int numeroInformado = int.Parse(Console.ReadLine());

        int elementoAtual = 0;
        int proximoElemento = 1;
        bool numeroPresente = false;

        Console.WriteLine("Sequ�ncia de Fibonacci at� " + numeroInformado + ":");

        Console.Write(elementoAtual + " " + proximoElemento + " ");

        while (true)
        {
            int soma = elementoAtual + proximoElemento;

            if (soma > numeroInformado)
                break;

            Console.Write(soma + " ");

            if (soma == numeroInformado)
                numeroPresente = true;

            elementoAtual = proximoElemento;
            proximoElemento = soma;
        }

        Console.WriteLine();

        if (numeroPresente)
            Console.WriteLine("O n�mero " + numeroInformado + " est� presente na sequ�ncia de Fibonacci.");
        else
            Console.WriteLine("O n�mero " + numeroInformado + " n�o est� presente na sequ�ncia de Fibonacci.");
    }
}