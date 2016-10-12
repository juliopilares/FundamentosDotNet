using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello World");
            Pessoa p = new Pessoa("Júlio Pilares");
            p.DigaOi();
            Console.ReadKey();
        }
    }
}
