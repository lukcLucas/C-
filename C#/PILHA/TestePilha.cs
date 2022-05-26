using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.PILHA
{
    class TestePilha
    {
        static void Main(string[] args)
        {
            var historicoOperacoes = new Pilha("LucasDev");

            historicoOperacoes.Adicionar("Iniciou um artigo.");
            historicoOperacoes.Adicionar("Escreveu - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
            historicoOperacoes.Adicionar("Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

            historicoOperacoes.Desfazer();

            historicoOperacoes.RetornarUltimaOperacao();

            Console.ReadLine();
        }

    }
}
