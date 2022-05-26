using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.FILA
{
    class TesteFila
    {

        static void Main(string[] args)
        {
            var fila = new Fila();

            fila.GerarSenha();
            fila.GerarSenha();
            fila.GerarSenha();

            fila.MostrarFila();

            fila.ChamarProximo();
            fila.ChamarProximo();

            fila.MostrarFila();

            fila.GerarSenha();

            fila.ChamarProximo();

            fila.MostrarFila();

            Console.ReadLine();
        }

    }
}
