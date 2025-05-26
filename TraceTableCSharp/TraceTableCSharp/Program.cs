namespace TraceTableCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continuar;

            do
            {
                Console.Clear();

                Console.WriteLine("Escolha o exercício de teste de mesa que deseja executar:");
                Console.WriteLine("[1] Exercício 01\n[2] Exercício 02\n[3] Exercício 03\n[0] Sair do programa");
                int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        Thread.Sleep(1000);
                        return;
                    case 1:
                        Console.WriteLine("Resultado do exercício 1:");
                        Ex01 exercicio1 = new Ex01();
                        exercicio1.Run();
                        break;
                    case 2:
                        Console.WriteLine("Resultado do exercício 2:");
                        Ex02 exercicio2 = new Ex02();
                        exercicio2.Run();
                        break;
                    case 3:
                        Console.WriteLine("Resultado do exercício 3:");
                        Ex03 exercicio3 = new Ex03();
                        exercicio3.Run();
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Escolha outra opção.");
                        break;
                }

                Console.WriteLine("\n");
                Console.WriteLine("Deseja executar outro exercício?\n[s] Sim\n[n] Não");
                continuar = Convert.ToChar(Console.ReadLine()!.ToLower());
            } while (continuar == 's');
        }
    }
}