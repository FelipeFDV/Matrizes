
namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) //este primeiro FOR vai povoar as LINHAS da matriz (m)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) //este segundo FOR vai povoar as COLUNAS da matriz (n)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("\nDigite um numero inteiro a ser procurado: ");
            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) //procurando nas linhas
            {
                for (int j = 0; j < n; j++) //procurando nas colunas
                {
                    if (mat[i, j] == X) //verificando na matriz o valor digitado e escrevendo onde X está perante outros valores da matriz
                    {                   //foi atribuido tambem, o valor i para linhas e j para colunas nos if's a seguir (escopo local)
                        Console.WriteLine("\nPosition " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}


/*
 * 
 * EXERCICIO MATRIZES
 
             Console.WriteLine("Digite o tamanho da matriz qudrada: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) //este primeiro FOR vai povoar as LINHAS da matriz
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) //este segundo FOR vai povoar as COLUNAS da matriz
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("\nDiagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " "); // imprimir linha i e coluna i (0,0  1,1  2,2)
            }
            Console.WriteLine();

            int count = 0; //foi declarada fora do FOR, pois senao nao daria para exibir la em baixo o valor
            for (int i = 0; i < n; i++) //este primeiro FOR vai checar as LINHAS da matriz
            {
                for (int j = 0; j < n; j++) //este segundo FOR vai checar as COLUNAS da matriz
                {
                    if (mat[i, j] < 0)
                    {
                        count++; //aqui será contado se o numero for negativo
                    }
                }
            }
            Console.WriteLine("\nnumeros negativos da matriz: " + count);

 */