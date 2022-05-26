using System;
using System.Collections.Generic;
using EstruturaDeDados.LSE;
/* 
 * Verificar se a fila está vazia
 * enqueue (Inserir um elemento no final da fila)
 * dequeue (Remover o elemento do inicio da fila)
 * Retornar o tamanho da fila
 * Retorna o elemento do inicio da fila
 * 
 * Uma fila implementa uma ordenacao de tipo FIFO(First-in, First-out),
 * onde o primeiro valor adicionado sera o primeiro a ser removido.
 * Basicamente, e a mesma coisa que no mundo real.Os primeiros
 * que chegam para serem atendidos,serao atendidos,por exemplo.
 * Em .NET, a classe que implementa essa estrutura de dados e a queue e 
 * Queue<T>
 * Operações

As principais operações de uma fila são:

    Enqueue: realiza a inserção de um valor.
    Peek: retorna o próximo valor, mas não remove.
    Dequeue: retorna o próximo valor, e remove.

Exemplo

Abaixo eu mostro um exemplo de seu uso. A 
idéia é permitir gerenciar senhas geradas
para fila de atendimento
 */


namespace EstruturaDeDados.FILA
{
    class Fila
    {
        private Queue<int> _fila;
        private int _proximoNumeroParaGerar = 1;

        public Fila()
        {
            _fila = new Queue<int>();
        }

        public int GerarSenha()
        {
            _fila.Enqueue(_proximoNumeroParaGerar);

            Console.WriteLine("Senha gerada.");

            return _proximoNumeroParaGerar++;
        }

        public void ChamarProximo()
        {
            var proximoNumeroDaFila = _fila.Dequeue();

            Console.WriteLine($"Próxima senha: {proximoNumeroDaFila}");
        }

        public void MostrarFila()
        {
            Console.Write("Senhas da Fila: ");

            foreach (var senha in _fila)
            {
                Console.Write(senha + " ");
            }

            Console.WriteLine();
        }

        public void ReiniciarFila()
        {
            _fila.Clear();
        }
       
		
	}
}
