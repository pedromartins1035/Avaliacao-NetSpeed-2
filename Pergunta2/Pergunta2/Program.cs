using System;

namespace Pergunta2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variáveis
            int cod = 0;
            float n1 = 0;
            float n2 = 0;
            float n3 = 0;
            float media = 0;

            Console.Write("Digite o código do aluno: ");
            cod = int.Parse(Console.ReadLine());

            if(cod > 0)
            {
                Console.Write("Digite o valor da primeira nota de 1 a 10: ");
                n1 = float.Parse(Console.ReadLine());

                Console.Write("Digite o valor da segunda nota de 1 a 10: ");
                n2 = float.Parse(Console.ReadLine());

                Console.Write("Digite o valor da terceira nota de 1 a 10: ");
                n3 = float.Parse(Console.ReadLine());

                if (n1 > n2 && n1 > n3)
                {
                    media = (n1 * 4 + n2 * 3 + n3 * 3) / 10;
                }
                else if (n2 > n1 && n2 > n3)
                {
                    media = (n2 * 4 + n1 * 3 + n3 * 3) / 10;
                }
                else
                {
                    media = (n3 * 4 + n1 * 3 + n2 * 3) / 10;
                }

                string dados = "Código: " + cod + " N1: " + n1 + " N2: " + n2 + " N3: " + n3 + " Média: " + media;

                if (media >= 5)
                {
                    Console.WriteLine(dados + " Aprovado");
                }
                else
                {
                    Console.WriteLine(dados + " Reprovado");
                }
            }
            else
            {
                Console.WriteLine("Este não é um valor válido para código. ");
            }
        }
    }
}
