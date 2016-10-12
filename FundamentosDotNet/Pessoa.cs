using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosDotNet
{
    public class Pessoa
    {
        private String Nome { get; set; }


        public Pessoa(String nome) {
            this.Nome = nome;
        }

        public void DigaOi() {
            Console.Write("Olá {0}!!!", this.Nome);
        }
    }
}
