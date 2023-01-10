using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Basica
{

    public class calculadora
    {
        public static void Main()
        {
            int opcao = 0, sair = 0;
            string repetir;


            do
            {
                Console.WriteLine(@"Insira uma das 5 opçoes
1 - Somar
2 - Subtração
3 - Multiplicação
4 - Divisão
5 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Somar();
                }
                else if (opcao == 2)
                {
                    Subtracao();
                }
                else if (opcao == 3)
                {
                    Multiplicacao();
                }
                else if (opcao == 4)
                {
                    Divisao();
                }
                else
                {
                    sair = 5;
                }
                Console.WriteLine("Deseja Continuar, escreva (sim) para continuar");
                repetir = Console.ReadLine();
            } while (repetir.ToLower() == "sim");
            Console.WriteLine("Clique em qualquer tecla para sair");
            Console.ReadKey();
        }
        public static double Somar()
        {
            double valor1, valor2, total;

            Console.WriteLine("Insira o primeiro valor");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor");
            valor2 = Convert.ToDouble(Console.ReadLine());

            total = valor1 + valor2;

            Console.WriteLine("O total é: " + total);
            return total;
        }
        public static double Subtracao()
        {
            double valor1, valor2, total;

            Console.WriteLine("Insira o primeiro valor");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor");
            valor2 = Convert.ToDouble(Console.ReadLine());

            total = valor1 - valor2;

            Console.WriteLine("O total é:" + total);
            return total;
        }
        public static double Multiplicacao()
        {
            double valor1, valor2, total;

            Console.WriteLine("Insira o primeiro valor");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor");
            valor2 = Convert.ToDouble(Console.ReadLine());

            total = valor1 * valor2;

            Console.WriteLine("O total da é: " + total.ToString("F2"));
            return total;
        }
        public static double Divisao()
        {
            double valor1, valor2, total;

            Console.WriteLine("Insira o primeiro valor");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor");
            valor2 = Convert.ToDouble(Console.ReadLine());

            total = valor1 / valor2;

            Console.WriteLine("O total da é: " + total.ToString("F2"));
            return total;
        }
    }




}
