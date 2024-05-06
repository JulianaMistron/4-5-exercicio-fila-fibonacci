using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_exercicio_fila_fibonacci
{
    internal class Fibonacci
    {
        int numero;
        Fibonacci proximo;

        public Fibonacci(int numero)
        {
            this.numero = numero;
            this.proximo = null;
        }
        public override string? ToString()
        {
            return ">>>>SEQUÊNCIA FIBONACCI: " + numero;
        }
        public void setProximo(Fibonacci numero)
        {
            proximo = numero;
        }
        public Fibonacci getProximo()
        {
            return proximo;
        }
        public int getValor()
        {
            return numero;
        }
    }

}