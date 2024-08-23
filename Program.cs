using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora cal = new Calculadora();
            Pessoa Eu = new Pessoa();
            Eu.nome = Eu.perguntarnome();
            int op = 0;
            do
            {
                Console.WriteLine($"Ola {Eu.nome}");
                Console.WriteLine("Escolha uma operacao\n1)soma\n2)subtracao\n3)multiplicacao\n4)divisao\n5)Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        cal.digitarn1();
                        cal.digitarn2();
                        cal.soma(cal.n1, cal.n2);
                        Console.WriteLine($"O resultado de {cal.n1} + {cal.n2} resulta em: {cal.resul}");
                        break;
                    case 2:
                        cal.digitarn1();
                        cal.digitarn2();
                        cal.subtracao(cal.n1, cal.n2);
                        Console.WriteLine($"O resultado de {cal.n1} - {cal.n2} resulta em: {cal.resul}");
                        break;
                    case 3:
                        cal.digitarn1();
                        cal.digitarn2();
                        cal.multiplicacao(cal.n1, cal.n2);
                        Console.WriteLine($"O resultado de {cal.n1} * {cal.n2} resulta em: {cal.resul}");
                        break;
                    case 4:
                        cal.digitarn1();
                        cal.digitarn2();
                        cal.divisao(cal.n1, cal.n2);
                        Console.WriteLine($"O resultado de {cal.n1} / {cal.n2} resulta em: {cal.resul}");
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        Console.ReadKey();
                        op = 5;
                        break;
                    default:
                        Console.WriteLine("Numero invalido!");
                        break;
                }
            } while (op != 5);
        }
    }
}
