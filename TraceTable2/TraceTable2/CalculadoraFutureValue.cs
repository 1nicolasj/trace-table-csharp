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
            double rendLiquido = 0;
            double rendAcumulada = valorPresente + rendLiquido;
            Console.WriteLine();
            for (int i = 1; i <= periodoMes; i++)
            {
                double valorF = CalculadoraFutureValue.CalcularValorFuturo(valorPresente, taxaJuros, i);
                rendLiquido = valorF - valorPresente;
                rendAcumulada += rendLiquido;

                Console.Write($"Mês: {i}\tTx Juros: {taxaJuros}%\tRendimento: R${valorF:F2}\tR. Líquida: R${rendLiquido:F2}\tR. Acumulada: R${rendAcumulada:F2}");
                Console.WriteLine();
            }
        }

        //recebe dados e mostra tabela com rendimento, renda líquida, renda acumulada e resgate
        public static void MostrarTabelaRendimentoComResgate(double valorPresente, double taxaJuros, int periodoMes, int mesResgate, double valorResgate)
        {
            double rendLiquido = 0;
            double rendAcumulada = valorPresente + rendLiquido;
            Console.WriteLine();
            for (int i = 1; i <= periodoMes; i++)
            {
                if (i == mesResgate)
                {
                    rendAcumulada -= valorResgate;
                    Console.WriteLine($"\nResgate de R${valorResgate:F2} no mês {i}\n");
                }
                double valorF = CalculadoraFutureValue.CalcularValorFuturo(valorPresente, taxaJuros, i);
                rendLiquido = valorF - valorPresente;
                rendAcumulada += rendLiquido;
                Console.Write($"Mês: {i}\tTx Juros: {taxaJuros}%\tRendimento: R${valorF:F2}\tR. Líquida: R${rendLiquido:F2}\tR. Acumulada: R${rendAcumulada:F2}");
                Console.WriteLine();
                
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
