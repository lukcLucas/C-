using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.ListaGenerica
{
    class Pessoa
    {

        /*
         * No meu caso precisava saber se existiam objetos 
         * com propriedades iguais na minha coleção para 
         * efetuar uma validação, é mais ou menos o cenário 
         * abaixo.
         * Primeiro vamos criar uma classe chamada Pessoa bem simples:
         */

        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public Pessoa(int id, string nome, string sobrenome)
        {
            this.Id = id;
            this.Nome = nome;
            this.SobreNome = sobrenome;

        }
    }
}
