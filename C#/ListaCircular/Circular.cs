using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.ListaCircular
{
    class   Circular
    {
        //Nodos
        public static string res;
        public static int x, saida;
        class nodo
        {
            public int dados;
            public nodo dir;
        }
        static nodo i, f, s, a, t;

        //Main
        static void Main(string[] args)
        {
            i = null; f = null; a = null; s = null; t = null;
            do
            {
                Console.Write("\n informe um nu numero: ");
                x = int.Parse(Console.ReadLine());
                captura();
                Console.Write("\nVocê deseja adicionar outro número (sim / nao):  ");
                res = Console.ReadLine();
            } while (res == "sim");
            imprimir();
        }

        //Actions

        //captura
        public static void captura()
        {
            if (i == null)
            {
                i = new nodo();
                i.dados = x;
                f = i;
                f.dir = null;
            }
            else
            {
                if (x < i.dados)
                {
                    t = new nodo();
                    t.dados = x;
                    t.dir = i;
                    i = t;
                }
                else
                {
                    if (x > f.dados)
                    {
                        t = new nodo();
                        t.dados = x;
                        f.dir = t;
                        f = t;
                        f.dir = i;
                    }
                    else
                    {
                        a = i;
                        s = i.dir;
                        while (x > s.dados)
                        {
                            a = s;
                            s = s.dir;
                        }
                        t = new nodo();
                        t.dados = x;
                        a.dir = t;
                        t.dir = s;
                    }
                }
            }
        }
        //imprimir
        public static void imprimir()
        {
            t = i;
            while (t != null)
            {
                Console.WriteLine(t.dados);
                t = t.dir;
            }
            Console.ReadKey();
        }
        //eliminar
        public static void eliminar()
        {

            if (x == i.dados)
            {
                t = new nodo();
                saida = i.dados;
                t = i;
                i = i.dir;
                //eliminar t
                Console.Write("\nOs dados {0} foram excluídos", saida);
            }
            else
            {
                a = i;
                s = i.dir;
                while (x != s.dados && s != i)
                {
                    a = s;
                    s = s.dir;
                }
                if (s == i)
                    Console.Write("\nEsses dados não existem");
                else
                {
                    if (s == f)
                    {
                        saida = f.dados;
                        f = a;
                        //elminar s
                        f.dir = i;
                        Console.Write("\nOs dados {0} foram excluídos\n", saida);
                    }
                    else
                    {
                        saida = s.dados;
                        a.dir = s.dir;
                        //eliminar s
                    }
                }
            }
        }
    }
}
