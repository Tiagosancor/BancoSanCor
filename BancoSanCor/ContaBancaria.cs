using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BancoSanCor
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;           
        }

        public ContaBancaria(int numero, string nome, double saldo) : this(numero, nome)
        {
            Saldo = saldo; 
        }

         public void ValorDoposito(double valor)
        {
            Saldo += valor;
        }

        public void ValorSaque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", "
                + "Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
