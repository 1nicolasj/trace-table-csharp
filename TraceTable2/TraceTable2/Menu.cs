using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceTable2
{
    internal class Menu
    {
        //TODO: Implementar os problemas 6, 7 e 8, MELHORAR MENU
        public static int MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine(@"
████████╗███████╗░██████╗████████╗███████╗  ██████╗░███████╗  ███╗░░░███╗███████╗░██████╗░█████╗░  
╚══██╔══╝██╔════╝██╔════╝╚══██╔══╝██╔════╝  ██╔══██╗██╔════╝  ████╗░████║██╔════╝██╔════╝██╔══██╗ 
░░░██║░░░█████╗░░╚█████╗░░░░██║░░░█████╗░░  ██║░░██║█████╗░░  ██╔████╔██║█████╗░░╚█████╗░███████║ 
░░░██║░░░██╔══╝░░░╚═══██╗░░░██║░░░██╔══╝░░  ██║░░██║██╔══╝░░  ██║╚██╔╝██║██╔══╝░░░╚═══██╗██╔══██║ 
░░░██║░░░███████╗██████╔╝░░░██║░░░███████╗  ██████╔╝███████╗  ██║░╚═╝░██║███████╗██████╔╝██║░░██║  
░░░╚═╝░░░╚══════╝╚═════╝░░░░╚═╝░░░╚══════╝  ╚═════╝░╚══════╝  ╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝░░╚═╝");
            Console.WriteLine();
            Console.WriteLine("|-----------------------|");
            Console.WriteLine("| Teste de mesa parte 2 |");
            Console.WriteLine("|-----------------------|");
            Console.WriteLine();
            Console.WriteLine("[1] Problema 1: Crie uma Tabela que calcule pela fórmula o Rendimento de um Investimento, lendo do teclado");
            Console.WriteLine("[2] Problema 2: Crie uma Tabela para 6 meses, taxa a.m. Rendimento para cada mês e mostrar todos os meses");
            Console.WriteLine("[3] Problema 3: Elabore um programa em C# que leia as Entradas e mostre o rendimento calculado");
            Console.WriteLine("[4] Problema 4: Elabore um tabela de iteração, caso ocorra um Resgate (saque) do Rendimento no 5º mês, o Saldo");
            Console.WriteLine("[5] Problema 5: Quais seriam os cálculos para Problema 2, para obter o Valor Futuro R$ 7.390,61");
            Console.WriteLine();
            Console.WriteLine("|-----------------------|");
            Console.WriteLine("| Teste de mesa parte 3 |");
            Console.WriteLine("|-----------------------|");
            Console.WriteLine();
            Console.WriteLine("[6] Problema 6: Crie uma Tabela e Programa C# que leia um menu para diversos valores da Entrada. ");
            Console.WriteLine("[7] Problema 7: Dado o enunciado do PROBLEMA 6. Mostre uma Tabela que calcula um Resgate do Rendimento no 5º mês");
            Console.WriteLine("[8] Problema 8: Dado o enunciado do PROBLEMA 7. Ler as entradas e calcular, mostrar em formato de Tabela");
            Console.WriteLine("\n[0] Sair do programa\n");
            Console.Write("Escolha uma opção do menu: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }

        public static void MenuInvestimentos()
        {
            char continuar;
            do
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Calculando diversos valores futuros");
                Console.WriteLine("-----------------------------------");

                double valorPresente, taxaJuros, periodo;
                CalculadoraFutureValue.SolicitarDadosInvestimento(out valorPresente, out taxaJuros, out periodo);

                CalculadoraFutureValue.MostrarTabelaRendimento(valorPresente, taxaJuros, periodo);

                Console.WriteLine("Deseja inserir mais valores?\n[N] Não\n[S] Sim ");
                continuar = Convert.ToChar(Console.ReadLine()!.ToLower());
            } while (continuar == 's');
        }

    }
}
