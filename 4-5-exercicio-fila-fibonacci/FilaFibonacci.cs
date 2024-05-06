using _4_5_exercicio_fila_fibonacci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_exercicio_fila_fibonacci
{
    internal class FilaFibonacci
    {
        Fibonacci head;
        Fibonacci tail;

        public FilaFibonacci()
        {
            this.head = null;
            this.tail = null;
        }

        public void GerarSequencia(int posicao)
        {
            int primeiroNumero = 1;
            int proximoNumero = 0;

            for (int i = 0; i < posicao; i++)
            {
                Fibonacci aux = new Fibonacci(primeiroNumero);

                this.push(aux);
                primeiroNumero = primeiroNumero + proximoNumero;
                proximoNumero = primeiroNumero - proximoNumero;
            }
        }

        public void push(Fibonacci aux)
        {
            if (vazia())
            {
                head = tail = aux;
            }
            else
            {
                tail.setProximo(aux);
                tail = aux;
            }
        }
        bool vazia()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void print()
        {
            Fibonacci aux = head;
            if (vazia())
            {
                Console.WriteLine("Fila vazia!");
                Console.WriteLine("Presione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getProximo();
                } while (aux != null);

                Console.WriteLine("Fim da impressão!");
                Console.WriteLine("Presione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
