// 1 - Criar uma váriavel ou um vetor
// 2 - Criar um laço para percorrer o vetor
// 3 - Para cada posição gerar um valor aleatório (valor ramdomico)
// 4 - Ordenar o vetor (Método Bubble Sort)


int tamanho = 100;
int[] vetor = new int[tamanho];

//Gerando um vetor com valores aleatórios
Random random = new Random();
for (int i = 0; i < vetor.Length; i++)
{   
    vetor[i] = random.Next(1000);
}

//Imprimir o vetor com valores sem ordenação
for (int i = 0; i < vetor.Length; i++)
{   
    Console.Write(vetor[i] + " ");
}


Console.WriteLine("\n");

//Ordenação do vetor com Bubble Sort
for(int i = 0; i < vetor.Length - 1; i++)
{
    if(vetor[i] > vetor[i + 1])
    {
        int aux = vetor[i];
        vetor[i] = vetor[(i + 1)];
        vetor[(i + 1)] = aux;
    }
}

//Imprimir o vetor com valores ordenados
for (int i = 0; i < vetor.Length; i++)
{   
    Console.Write(vetor[i] + " ");
}