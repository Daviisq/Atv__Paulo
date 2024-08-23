using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_08
{
    internal class Calculadora
    {
        public float n1;
        public float n2;
        public float resul;

        public float digitarn1()
        {
            Console.WriteLine("Digite um valor:");
            n1 = float.Parse(Console.ReadLine());
            return n1;
        }
        public float digitarn2()
        {
            Console.WriteLine("Digite outro valor:");
            n2 = float.Parse(Console.ReadLine());
            return n2;
        }

        public float soma(float n1, float n2) {
            return resul = n1 + n2;
        }
        public float subtracao(float n1, float n2)
        {
            return resul = n1 - n2;
        }
        public float multiplicacao(float n1, float n2)
        {
            return resul = n1 * n2;
        }
        public float divisao(float n1, float n2)
        {
            while (n2 == 0)
            {
                Console.WriteLine("Impossivel dividir por 0");
                n2 = digitarn2();
            }
            return resul = n1 / n2;
        }
    }
}
