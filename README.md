# target-sistemas-teste

Observe o trecho de código abaixo:
int INDICE = 13, SOMA = 0, K = 0;
Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
Imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA?
<br/>
Resposta: Ao final do processamento, a resposta será 78. Minha linha de raciocínio foi: O código primeiro verifica a condição K < INDICE e caso seja TRUE, o código é executado, portanto:
1° iteração: K = 1; SOMA = 0 + 1 = 1 <br/>
2° iteração: K = 2; SOMA = 1 + 2 = 3 <br/>
3° iteração: K = 3; SOMA = 3 + 3 = 6 <br/> 
4° iteração: K = 4; SOMA = 6 + 4 = 10 <br/>
5° iteração: K = 5; SOMA = 10 + 5 = 15 <br/>
6° iteração: K = 6; SOMA = 15 + 6 = 21 <br/>
7° iteração: K = 7; SOMA = 21 + 7 = 28 <br/>
8 iteração: K = 8; SOMA = 28 + 8 = 36 <br/>
9° iteração: K = 9; SOMA = 36 + 9 = 45 <br/>
10° iteração: K = 10; SOMA = 45 + 10 = 55 <br/>
11° iteração: K = 11; SOMA = 55 + 11 = 66 <br/>
12° iteração: K = 12; SOMA = 66 + 12 = 78
