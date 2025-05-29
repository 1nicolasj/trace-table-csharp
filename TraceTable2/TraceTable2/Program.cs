namespace TraceTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            do
            {
                int opcao = Menu.MostrarMenu();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo da aplicação");
                        Thread.Sleep(1000);
                        return;
                    case 1:
                        Console.Clear();
                        Problem1.Run();
                        break;
                    case 2:
                        Console.Clear();
                        Problem2.Run();
                        break;
                    case 3:
                        Console.Clear();
                        Problem3.Run();
                        break;
                    case 4:
                        Console.Clear();
                        Problem4.Run();
                        break;
                    case 5:
                        Console.Clear();
                        Problem5.Run();
                        break;
                    case 6:
                        Console.Clear();
                        Problem6.Run();
                        break;
                    case 7:
                        Console.Clear();
                        Problem7.Run();
                        break;
                    case 8:
                        Console.Clear();
                        Problem8.Run();
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }


                
                Console.WriteLine("\nDeseja calcular outro problema?\n[s] Sim\n[n] Não");
                continuar = Convert.ToChar(Console.ReadLine()!.ToLower());
            } while (continuar == 's');
        }
    }
}