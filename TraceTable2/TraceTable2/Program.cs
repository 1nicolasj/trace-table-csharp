namespace TraceTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            do
            {
                int opcao = MostrarMenu();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo da aplicação");
                        Thread.Sleep(1000);
                        return;
                    case 1:
                        Problem1.Run();
                        break;
                    case 2:
                        Problem2.Run();
                        break;
                    case 3:
                        Problem3.Run();
                        break;
                    case 4:
                        Problem4.Run();
                        break;
                    case 5:
                        Problem5.Run();
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }


                
                Console.WriteLine("\nDeseja calcular outro problema?\n[s] Sim\n[n] Não");
                continuar = Convert.ToChar(Console.ReadLine()!.ToLower());
            } while (continuar == 's');
        }

        public static int MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("TESTE DE MESA PARTE 2");
            Console.WriteLine("[1] Problema 1: Crie uma Tabela que calcule pela fórmula o Rendimento de um Investimento, lendo do teclado");
            Console.WriteLine("[2] Problema 2: Crie uma Tabela para 6 meses, taxa a.m. Rendimento para cada mês e mostrar todos os meses");
            Console.WriteLine("[3] Problema 3: Elabore um programa em C# que leia as Entradas e mostre o rendimento calculado");
            Console.WriteLine("[4] Problema 4: Elabore um tabela de iteração, caso ocorra um Resgate (saque) do Rendimento no 5º mês, o Saldo");
            Console.WriteLine("[5] Problema 5: Quais seriam os cálculos para Problema 2, para obter o Valor Futuro R$ 7.390,61");
            Console.WriteLine("[0] Sair do programa");

            Console.Write("Escolha uma opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }
    }
}