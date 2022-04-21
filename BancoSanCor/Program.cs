using System;
using System.Globalization;

namespace BancoSanCor
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria cb;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n?) ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósto inicial: ");
                double valordepositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb = new ContaBancaria(numero, nome, valordepositoinicial);
            }
            else
            {
                cb = new ContaBancaria(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(cb);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.ValorDoposito(valor1);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.ValorSaque(valor1);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cb);
        }
    }
}
