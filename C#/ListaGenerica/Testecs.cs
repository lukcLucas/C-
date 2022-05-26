using System;
using System.Collections.Generic;
using System.Linq;


namespace EstruturaDeDados.ListaGenerica
{
    /*Depois vamos criar uma lista com algumas “Pessoas” e listar em tela três valores:
     * a quantidade de itens duplicados com mesmo id, nome e sobrenome;
     * a quantidade de itens duplicados com mesmo nome e sobrenome;
     * a quantidade de itens duplicados somente com o mesmo sobrenome.
     */
    class Testecs
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa(1, "Jose", "Silva"));
            pessoas.Add(new Pessoa(2, "Maria", "Gomes"));
            pessoas.Add(new Pessoa(1, "Jose", "Silva"));
            pessoas.Add(new Pessoa(3, "Roberto", "Justus"));
            pessoas.Add(new Pessoa(4, "Alice", "Silva"));
            pessoas.Add(new Pessoa(1, "Jose", "Silva"));

            int itens_duplicados = pessoas
                .GroupBy(p => new { p.Id, p.Nome, p.SobreNome })
                .Where(x => x.Count() > 1)
                .Sum(x => x.Count());

            int itens_duplicados_por_nome_e_sobrenome = pessoas
                .GroupBy(p => new { p.Nome, p.SobreNome })
                .Where(x => x.Count() > 1)
                .Sum(x => x.Count());

            int itens_duplicados_por_sobrenome = pessoas
                .GroupBy(p => new { p.SobreNome })
                .Where(x => x.Count() > 1)
                .Sum(x => x.Count());

            Console.WriteLine("Itens duplicados: " + itens_duplicados);
            Console.WriteLine("Itens com mesmo nome e sobrenome: " + itens_duplicados_por_nome_e_sobrenome);
            Console.WriteLine("Itens com mesmo sobrenome: " + itens_duplicados_por_sobrenome);
            Console.ReadLine();




        }
    }
}
