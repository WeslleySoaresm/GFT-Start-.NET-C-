// Declara um array de strings que pode conter 4 elementos
string[] nomes = new string[4];

// Atribui valores a cada posição (índice)
nomes[0] = "Ana";
nomes[1] = "Carlos";
nomes[2] = "Beatriz";
nomes[3] = "Daniel";

Console.WriteLine("Nomes em ordem de inserção:");
// Acessando e exibindo um elemento específico
Console.WriteLine($"O segundo nome é: {nomes[1]}"); // Saída: Carlos

// Percorrendo o array com um laço 'for'
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Índice {i}: {nomes[i]}");
}



// Declara e inicializa um array de inteiros
int[] numeros = new int[] { 10, 25, 8, 42, 15 };

// Sintaxe ainda mais curta (a mais comum)
double[] notas = { 9.5, 8.0, 7.5, 10.0 };

Console.WriteLine("\nNotas dos alunos:");
// Percorrendo o array com um laço 'foreach' (mais simples)
foreach (double nota in notas)
{
    Console.WriteLine(nota);
}


// Declara uma matriz 2x3 (2 linhas e 3 colunas)
int[,] matriz = new int[2, 3];

// Preenchendo a matriz
matriz[0, 0] = 1; matriz[0, 1] = 2; matriz[0, 2] = 3;
matriz[1, 0] = 4; matriz[1, 1] = 5; matriz[1, 2] = 6;

// Também pode ser inicializado diretamente
string[,] tabuleiro = {
    { "A1", "A2", "A3" },
    { "B1", "B2", "B3" }
};

Console.WriteLine("\nConteúdo da matriz (tabuleiro):");
// Percorrendo com laços aninhados
for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < tabuleiro.GetLength(1); coluna++)
    {
        Console.Write(tabuleiro[linha, coluna] + "\t"); // '\t' adiciona um tab
    }
    Console.WriteLine(); // Pula para a próxima linha
}


// Declara um array que conterá 3 arrays de inteiros
int[][] arrayDenteado = new int[3][];

// Inicializa cada array interno com um tamanho diferente
arrayDenteado[0] = new int[] { 1, 2 };          // Primeira linha tem 2 elementos
arrayDenteado[1] = new int[] { 3, 4, 5, 6 };    // Segunda linha tem 4 elementos
arrayDenteado[2] = new int[] { 7, 8, 9 };       // Terceira linha tem 3 elementos

Console.WriteLine("\nConteúdo do array denteado:");
// Percorrendo o array externo
foreach (int[] linha in arrayDenteado)
{
    // Percorrendo cada array interno
    foreach (int numero in linha)
    {
        Console.Write(numero + " ");
    }
    Console.WriteLine();
}


int[] numerosSorteados = { 34, 12, 5, 48, 21, 1 };

Console.WriteLine("\nMétodos da classe Array:");
Console.WriteLine("Array original: " + string.Join(", ", numerosSorteados));

// Ordenando o array
Array.Sort(numerosSorteados);
Console.WriteLine("Array ordenado: " + string.Join(", ", numerosSorteados));

// Invertendo a ordem
Array.Reverse(numerosSorteados);
Console.WriteLine("Array invertido: " + string.Join(", ", numerosSorteados));

// Encontrando o índice de um elemento
int indiceDo21 = Array.IndexOf(numerosSorteados, 21);
Console.WriteLine($"O número 21 está no índice: {indiceDo21}");

// Limpando parte do array (substitui por valores padrão, 0 para int)
Array.Clear(numerosSorteados, 0, 2); // Limpa 2 elementos a partir do índice 0
Console.WriteLine("Array após limpar os 2 primeiros elementos: " + string.Join(", ", numerosSorteados));




// Cria uma lista de strings. Não é necessário definir um tamanho inicial.
List<string> listaDeCompras = new List<string>();

Console.WriteLine("\nExemplo com List<T>:");

// Adicionando itens à lista
listaDeCompras.Add("Maçã");
listaDeCompras.Add("Leite");
listaDeCompras.Add("Pão");

// Inicialização com valores
List<double> temperaturas = new List<double> { 25.3, 30.1, 19.8 };

// Acessando um item (mesma sintaxe de array)
Console.WriteLine($"Primeiro item da lista: {listaDeCompras[0]}");

// Removendo um item
listaDeCompras.Remove("Leite");

Console.WriteLine($"Itens na lista de compras (agora com {listaDeCompras.Count} itens):");
foreach (string item in listaDeCompras)
{
    Console.WriteLine("- " + item);
}