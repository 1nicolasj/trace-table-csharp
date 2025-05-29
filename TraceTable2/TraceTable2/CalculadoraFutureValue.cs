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
        public static double CalcularValorFuturo(double valorPresente, double taxaJuros, double periodoMes)
        {
            taxaJuros /= 100; //de porcentagem para decimal
            return valorPresente * Math.Pow((1 + taxaJuros), periodoMes);
        }
        //formula para o exercicio 6 para frente
        public static double CalcularValorFuturoComDatas(double valorPresente, double taxaJuros, DateTime dataInicial, DateTime dataFinal, char tipoPeriodo)
        {
            if (dataFinal < dataInicial)
            {
                Console.WriteLine("A data final deve ser maior que a data inicial.");
                return 0;
            }
                
            int totalDias = (dataFinal - dataInicial).Days;

            double periodo;
            if (tipoPeriodo == 'm')
            {
                periodo = totalDias / 30.0;
            }
            else if (tipoPeriodo == 'a')
            {
                periodo = totalDias / 365.0;
            }
            else
            {
                Console.WriteLine("Tipo de período inválido. Use 'm' para mensal ou 'a' para anual.");
                return 0;
            }

            return CalcularValorFuturo(valorPresente, taxaJuros, periodo);
        }

        //recebe dados e mostra tabela com rendimento, renda líquida e renda acumulada
        public static void MostrarTabelaRendimento(double valorPresente, double taxaJuros, double periodo)
        {
            double rendimento = valorPresente;
            double rendaAcumulada = 0;
            Console.WriteLine();
            Console.WriteLine("Loop a.m.\tTaxa Juros\tRendimento\tRend. Líquido\tRenda Acumulada");
            for (int i = 1; i <= periodo; i++)
            {
                double rendaLiquida = rendimento * (taxaJuros / 100);
                rendimento += rendaLiquida;
                rendaAcumulada += rendaLiquida;

                Console.WriteLine($"{i}\t\t{taxaJuros:F2}%\t\tR${rendimento:F2}\tR${rendaLiquida:F2}\t\tR${rendaAcumulada:F2}");
            }
        }

        //recebe dados e mostra tabela com rendimento, renda líquida, renda acumulada e o resgate
        public static void MostrarTabelaRendimentoComResgate(double valorPresente, double taxaJuros, int periodoMes, int mesResgate, double valorResgate)
        {
            double saldo = valorPresente;
            double rendaAcumulada = 0;
            Console.WriteLine();
            Console.WriteLine("Mês\tTaxa Juros\tRendimento\tR. Líquida\tR. Acumulada\tSaldo Final\tResgate\t");
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
                Console.WriteLine($"{i}\t{taxaJuros:F2}%\t\tR${saldo + resgate:F2}\tR${rendaLiquida:F2}\t\tR${rendaAcumulada:F2}\tR${saldo:F2}   {(resgate > 0 ? $"\tR${resgate:F2}" : "\tR$00,00")}"); //ternario para verificar resgate
            }
        }

        //solicita dados ao usuario e retorna valor futuro
        public static void SolicitarDadosInvestimento(out double valorPresente, out double taxaJuros, out double periodo)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Informe os dados do investimento");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Informe o valor presente: ");
            valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a taxa de juros (em % usando ,): ");
            taxaJuros = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A taxa é anual ou mensal?");
            Console.WriteLine("[A] Anual\n[M] Mensal\n");
            Console.Write("Escolha uma opção: ");
            char mesOuAno = Convert.ToChar(Console.ReadLine().ToLower());


            Console.Write("\nInforme a data inicial (exemplo: 1981-12-13): ");
            DateTime dataInicial = DateTime.Parse(Console.ReadLine());
            Console.Write("Informe a data final (exemplo: 2019-11-23): ");
            DateTime dataFinal = DateTime.Parse(Console.ReadLine());

            if (dataFinal < dataInicial)
            {
                Console.WriteLine("Erro. A data final tem que ser maior que a inicial");
                periodo = 0;
                return;
            }
            else
            {
                //pegando o total de dias no periodo informado
                TimeSpan diferenca = dataFinal - dataInicial;
                int totalDias = diferenca.Days;

                if (mesOuAno == 'm')
                {
                    periodo = totalDias / 30.0; //convertendo dias para meses
                }
                else if (mesOuAno == 'a')
                {
                    periodo = totalDias / 365.0; //convertendo dias para anos
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    periodo = 0;
                }
            }
        }
    }
}
