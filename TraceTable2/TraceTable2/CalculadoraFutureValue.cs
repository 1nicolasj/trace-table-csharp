using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTable2
{
    internal class CalculadoraFutureValue
    {
        //solicita dados ao usuario
        public static void SolicitarDadosInvestimento(out double valorPresente, out double taxaJuros, out double periodo, out char mesOuAno, out DateTime dataFinal, out int totalDias)
        {
            char continuar;
            do
            {
                Console.WriteLine("|----------------------------------|");
                Console.WriteLine("| Informe os dados do investimento |");
                Console.WriteLine("|----------------------------------|");

                Console.WriteLine("Informe o valor presente: ");
                valorPresente = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a taxa de juros (em % usando ,): ");
                taxaJuros = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("A taxa é anual ou mensal?");
                Console.WriteLine("[A] Anual\n[M] Mensal\n");
                Console.Write("Escolha uma opção: ");
                mesOuAno = Convert.ToChar(Console.ReadLine().ToLower());


                Console.Write("\nIniciando a simulação de rendimento com a data atual. ");
                DateTime dataInicial = DateTime.Today;

                Console.Write("Informe a duração do investimento em MESES (ex: 8): ");
                int mesesDuracao = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Informe os DIAS adicionais para a duração (além dos {mesesDuracao} meses, ex: 10): ");
                int diasDuracao = Convert.ToInt32(Console.ReadLine());

                dataFinal = dataInicial.AddMonths(mesesDuracao).AddDays(diasDuracao);
                Console.WriteLine($"A data final calculada para o investimento é: {dataFinal:yyyy-MM-dd}");

                if (dataFinal < dataInicial)
                {
                    Console.WriteLine("Erro. A data final calculada é menor que a data inicial. O período será 0 dias.");
                    totalDias = 0;
                    dataFinal = dataInicial;
                    periodo = 0.0;
                }
                else
                {
                    totalDias = (dataFinal - dataInicial).Days; //contando a quantidade de dias

                    if (mesOuAno == 'm')
                    {
                        periodo = totalDias / (365.25 / 12); //convertendo dias para meses do ano
                    }
                    else if (mesOuAno == 'a')
                    {
                        periodo = totalDias / 365.25; //convertendo dias para anos
                    }
                    else
                    {
                        Console.WriteLine("Tipo de período inválido. Use 'm' para mensal ou 'a' para anual.");
                        periodo = 0.0;
                    }
                }

                Console.WriteLine($"O período total do investimento será de {mesesDuracao} meses e {diasDuracao} dias, totalizando {totalDias} dias.");
                double valorF = CalculadoraFutureValue.CalcularValorFuturoDatas(valorPresente, taxaJuros, mesOuAno, totalDias);
                Console.WriteLine($"O valor futuro é: R$ {valorF:F2}");

                Console.WriteLine();
                Console.WriteLine("Deseja sair da simulação e não calcular mais valores?\n[S] Sim\n[N] Não");
                continuar = Convert.ToChar(Console.ReadLine()!.ToLower());
            } while (continuar != 's');
            
        }


        //fórmula valor futuro
        public static double CalcularValorFuturo(double valorPresente, double taxaJuros, double periodo)
        {
            taxaJuros /= 100; //de porcentagem para decimal
            return valorPresente * Math.Pow((1 + taxaJuros), periodo);
        }
        //formula para o exercicio 6 para frente
        public static double CalcularValorFuturoDatas(double valorPresente, double taxaJuros, char mesOuAno, int totalDias)
        {
            if (totalDias <= 0) return valorPresente;
            double taxaDiariaPercentual = CalcularTaxaDiaria(taxaJuros, mesOuAno);
            double taxaDiariaDecimal = taxaDiariaPercentual / 100.0;
            return valorPresente * Math.Pow(1 + taxaDiariaDecimal, totalDias);
        }


        public static double CalcularTaxaDiaria(double taxaPercentual, char mesOuAno)
        {
            double taxaDecimal = taxaPercentual / 100.0;
            double taxaDiariaDecimal;
            if (mesOuAno == 'a')
            {
                taxaDiariaDecimal = Math.Pow(1 + taxaDecimal, 1.0 / 365.25) - 1; //convert para taxa diária
            }
            else 
            {
                taxaDiariaDecimal = Math.Pow(1 + taxaDecimal, 1.0 / (365.25 / 12.0)) - 1; //
            }
            return taxaDiariaDecimal * 100.0;
        }


        //recebe dados e mostra tabela com rendimento, renda líquida e renda acumulada
        public static void MostrarTabelaRendimento(double valorPresente, double taxaJuros, double periodo)
        {
            double rendimento = valorPresente;
            double rendaAcumulada = 0;
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine("| Tabela de rendimento de investimento |");
            Console.WriteLine("|--------------------------------------|");
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
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("| Tabela de rendimento de investimento com resgate |");
            Console.WriteLine("|--------------------------------------------------|");
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

        public static void MostrarTabelaRendimentoDiario(double valorPresente, double taxaJuros, char mesOuAno, int totalDias, DateTime dataInicial)
        {
            if (totalDias <= 0)
            {
                return;
            }

            double taxaDiariaPercentual = CalcularTaxaDiaria(taxaJuros, mesOuAno);
            double taxaDiariaDecimal = taxaDiariaPercentual / 100.0;
            double saldo = valorPresente;
            double rendaAcumulada = 0;

            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("| Tabela de rendimento diário |");
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("Data      \tTaxa Diaria\tSaldo Início\tJuros Dia\tJuros Acum.\tSaldo Final");
            //Console.WriteLine("----------\t----------\t------------\t---------\t-----------\t-----------");

            for (int i = 0; i < totalDias; i++)
            {
                DateTime dataAtual = dataInicial.AddDays(i);
                double saldoInicioDia = saldo;
                double jurosDoDia = saldo * taxaDiariaDecimal;
                saldo += jurosDoDia;
                rendaAcumulada += jurosDoDia;
                Console.WriteLine($"{dataAtual:yyyy-MM-dd}\t{taxaDiariaPercentual:F2}%\t\tR${saldoInicioDia:F2}\tR${jurosDoDia:F2}\t\tR${rendaAcumulada:F2}\t\tR${saldo:F2}");
            }
            Console.WriteLine($"\nValor Futuro final: R${saldo:F2}");
        }


        public static void MostrarTabelaRendimentoDiarioComResgate(double valorPresente, double taxaJuros, char mesOuAno, int totalDias, int diaDoResgate, double valorResgate, DateTime dataInicial)
        {
            if (totalDias <= 0)
            {
                return;
            }
            
            if (diaDoResgate <= 0 || diaDoResgate > totalDias)
            {
                Console.WriteLine($"\nDia de resgate ({diaDoResgate}) fora do período total dos {totalDias} dias.");
                Console.WriteLine("Mostrando tabela diária sem resgate:");
                MostrarTabelaRendimentoDiario(valorPresente, taxaJuros, mesOuAno, totalDias, dataInicial);
                return;
            }

            double taxaDiariaPercentual = CalcularTaxaDiaria(taxaJuros, mesOuAno);
            double taxaDiariaDecimal = taxaDiariaPercentual / 100.0;
            double saldo = valorPresente;
            double rendaAcumulada = 0; 
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("| Tabela de rendimento diário com resgate |");
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("Data      \tTaxa Diaria\tSaldo Início\tJuros Dia\tResgate  \tJuros Acum.\tSaldo Final");
            
            for (int i = 0; i < totalDias; i++)
            {
                DateTime dataAtual = dataInicial.AddDays(i);
                double saldoInicioDia = saldo;
                double jurosDoDia = saldo * taxaDiariaDecimal;
                saldo += jurosDoDia;
                rendaAcumulada += jurosDoDia;
                double resgate = 0;

                if ((i + 1) == diaDoResgate)
                {
                    resgate = valorResgate;
                    if (saldo < resgate) 
                    {
                        Console.WriteLine($"\nErro. Tentativa de resgatar R${resgate:F2} mas saldo total é R${saldo:F2}. Resgatando saldo disponível.");
                        resgate = saldo;
                    }
                    saldo -= resgate;
                }
                Console.WriteLine($"{dataAtual:yyyy-MM-dd}\t{taxaDiariaPercentual:F2}%\t\tR${saldoInicioDia:F2}\t\tR${jurosDoDia:F2}\t\tR${resgate:F2}\t\tR${rendaAcumulada:F2}\t\tR${saldo:F2}");
            }
            Console.WriteLine($"\nValor Futuro final (com resgate): R${saldo:F2}");
        }

    }
}


