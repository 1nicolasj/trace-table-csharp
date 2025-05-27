using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTable2
{
    internal class CalculadoraFutureValue
    {
        //fórmula valor futuro
        public static double CalcularValorFuturo(double valorPresente, double taxaJuros, int periodoMes)
        {
            taxaJuros /= 100; //de porcentagem para decimal
            return valorPresente * Math.Pow((1 + taxaJuros), periodoMes);
        }

        //recebe dados e mostra tabela com rendimento, renda líquida e renda acumulada
        public static void MostrarTabelaRendimento(double valorPresente, double taxaJuros, int periodoMes)
        {
            double rendimento = valorPresente;
            double rendaAcumulada = 0;
            Console.WriteLine();
            Console.WriteLine("Loop a.m.\tTaxa Juros\tRendimento\tRend. Líquido\tRenda Acumulada");
            for (int i = 1; i <= periodoMes; i++)
            {
                double rendaLiquida = rendimento * (taxaJuros / 100);
                rendimento += rendaLiquida;
                rendaAcumulada += rendaLiquida;

                Console.WriteLine($"{i}\t\t{taxaJuros:F2}%\t\tR${rendimento:F2}\tR${rendaLiquida:F2}\t\tR${rendaAcumulada:F2}");
            }
        }

        //recebe dados e mostra tabela com rendimento, renda líquida, renda acumulada e resgate
        public static void MostrarTabelaRendimentoComResgate(double valorPresente, double taxaJuros, int periodoMes, int mesResgate, double valorResgate)
        {
            double saldo = valorPresente;
            double rendaAcumulada = 0;
            Console.WriteLine();
            Console.WriteLine("Mês\tTaxa Juros\tRendimento\tR. Líquida\tR. Acumulada\tResgate\t\tSaldo Final");
            for (int i = 1; i <= periodoMes; i++)
            {
                double rendaLiquida = saldo * (taxaJuros / 100);
                saldo += rendaLiquida;
                rendaAcumulada += rendaLiquida;

                double resgate = 0;
                if (i == mesResgate)
                {
                    resgate = valorResgate;
                    saldo -= resgate;
                }
                Console.WriteLine($"{i}\t{taxaJuros:F2}%\t\tR${saldo + resgate:F2}\tR${rendaLiquida:F2}\tR${rendaAcumulada:F2}\t\t{(resgate > 0 ? $"R${resgate:F2}" : "-")}\t\tR${saldo:F2}"); //ternario para verificar resgate
            }
        }

        //solicita dados ao usuario e retorna valor futuro
        public static void SolicitarDadosInvestimento(out double valorPresente, out double taxaJuros, out int periodo)
        {
            Console.WriteLine("Informe o valor presente: ");
            valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a taxa de juros (em porcentagem usando ,): ");
            taxaJuros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o período (em meses ou anos)");
            periodo = Convert.ToInt32(Console.ReadLine());
            double valorF = CalculadoraFutureValue.CalcularValorFuturo(valorPresente, taxaJuros, periodo);
        }

    }
}
