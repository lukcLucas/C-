using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.LDE
{


    //LinkedList

    class ListaDupla
    {
        // dentro do main

        //LinkedList<int> list = new LinkedList<int>();
        //LinkedListNode<int> head = list.AddFirst(5);
        //list.AddAfter(head, 10);
        //Console.WriteLine(list.First.Value);
        //Console.WriteLine(list.First.Next.Value);


        // Aqui está um exemplo de adição e remoção muito rápida de elementos:
        /*
        AddAfter () - Adiciona um novo elemento após o elemento fornecido.
        AddBefore () - Adiciona um novo elemento antes do elemento fornecido.
        AddFirst () - Adiciona um novo elemento no início da lista.
        AddLast () - Adiciona um novo elemento no final da lista.
        Primeiro - uma propriedade que retorna o primeiro elemento.
        Último - A propriedade que retorna o último elemento.
        RemoveFirst () - Remove o primeiro elemento.
        RemoveLast () - Remove o último elemento.

         */
        static void Main(string[] args)
        {
            // nicialização e preenchimento da lista ligada
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            LinkedListNode<int> middle = list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            // adicionar e deletar no meio da lista
            list.AddAfter(middle, 32);
            list.AddAfter(middle, 31);
            list.Remove(middle);

            // imprimindo a lista
            foreach (int i in list)
                Console.Write("{0}, ", i);

            Console.ReadKey();
        }

    }
    
    
}
