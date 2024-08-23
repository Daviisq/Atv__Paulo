using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_08
{
    internal class Pessoa
    {
        public string nome;

        public string perguntarnome() 
        {
            string nome;
            Console.WriteLine("Qual seu nome?");
            nome=Console.ReadLine();
            return nome;
        }
    }
}
