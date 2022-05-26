using System;
using EstruturaDeDados.LSE;
using System.Collections.Generic;
/*
* Verificar se a pilha está vazia
* Empilhar (Inserir um elemento no topo da pilha)
* Desempilhar (Remover o elemento do topo da pilha)
* Retornar o tamanho da pilha
* Retorna o elemento (topo da pilha)
* 
* Uma pilha implementa uma ordenação de tipo LIFO (Last-In, First-Out), onde o último valor adicionado será o primeiro a ser removido. Um exemplo do mundo real é o de pilha de pratos para lavar, onde o que estiver no topo (último empilhado) será o primeiro a ser lavado. Em .NET, a classe que implementa essa estrutura de dados é a Stack e Stack<T>.
Operações

    Push: realiza a inserção de um valor.
    Peek: retorna o próximo valor, mas não o remove da pilha.
    Pop: retorna o próximo valor e remove da pilha.
*/

namespace EstruturaDeDados.PILHA
{


    public class Pilha
    {

        private Stack<string> _historico;

        public Pilha(string nomeUsuario)
        {
            NomeUsuario = nomeUsuario;

            _historico = new Stack<string>();
        }

        public string NomeUsuario { get; private set; }

        public void Adicionar(string nome)
        {
            _historico.Push(nome);
        }

        public void Desfazer()
        {
            Console.WriteLine($"Última operação desfeita.");

            _historico.Pop();
        }

        public string RetornarUltimaOperacao()
        {
            var ultimaOperacao = _historico.Peek();

            return ultimaOperacao;
        }

    }
}
