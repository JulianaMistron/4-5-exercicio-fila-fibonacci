//faça um programa coloque os n valores da sequencia fibonacci em uma fila(fala qtos numeros quer guardar,
//e guarda na pilha)

using _4_5_exercicio_fila_fibonacci;
internal class Program
{
    private static void Main(string[] args)
    {
        FilaFibonacci filaFibonacci = new FilaFibonacci();

        Console.WriteLine("Informe a posição da sequência Fibonacci que você deseja gerar: ");
        int posicao = int.Parse(Console.ReadLine());
        filaFibonacci.GerarSequencia(posicao);


        Console.WriteLine("\nNúmeros da sequência Fibonacci armazenados na fila:");
        filaFibonacci.print();
    }
}
