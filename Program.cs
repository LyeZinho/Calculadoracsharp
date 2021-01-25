using System;


namespace Calculadoracsharp
{

    class CalcMain
    {
        static int StrConvert(string entrada)//Converte string para int
        {
            int saida = Convert.ToInt32(entrada);
            return saida;
        }

        public static void Multiply()
        {
            Console.Clear();//Limpa tela anterior

            Console.WriteLine("Digite o primeiro valor!");
            string entrada1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor!");
            string entrada2 = Console.ReadLine();

            int saida1 = StrConvert(entrada1);
            int saida2 = StrConvert(entrada2);

            int resultado = saida1 * saida2;

            Console.WriteLine("O resultado e: {0}", resultado);
            Console.ReadLine();
            Program.MenuInterface();
        }

        public static void Divisao()
        {
            Console.Clear();//Limpa tela anterior

            Console.WriteLine("Digite o primeiro valor!");
            string entrada1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor!");
            string entrada2 = Console.ReadLine();

            float saida1 = StrConvert(entrada1);
            float saida2 = StrConvert(entrada2);

            float resultado = saida1 / saida2;

            Console.WriteLine("O resultado e: {0}", resultado);
            Console.ReadLine();
            Program.MenuInterface();
        }

        public static void Subtracao()
        {
            Console.Clear();//Limpa tela anterior

            Console.WriteLine("Digite o primeiro valor!");
            string entrada1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor!");
            string entrada2 = Console.ReadLine();

            int saida1 = StrConvert(entrada1);
            int saida2 = StrConvert(entrada2);

            int resultado = saida1 - saida2;

            Console.WriteLine("O resultado e: {0}", resultado);
            Console.ReadLine();
            Program.MenuInterface();
        }

        public static void Soma()
        {
            Console.Clear();//Limpa tela anterior

            Console.WriteLine("Digite o primeiro valor!");
            string entrada1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor!");
            string entrada2 = Console.ReadLine();

            int saida1 = StrConvert(entrada1);
            int saida2 = StrConvert(entrada2);

            int resultado = saida1 + saida2;

            Console.WriteLine("O resultado e: {0}", resultado);
            Console.ReadLine();
            Program.MenuInterface();
        }
    }


    class Program//Base principal / interfaçe
    {

        public static void MenuInterface()
        {
            Console.Clear();
            string entrada = "";
            Console.WriteLine("\n \n");
            do
            {

                Console.WriteLine("    ██████╗ █████╗ ██╗      ██████╗██╗   ██╗██╗      █████╗ ████████╗ ██████╗ ██████╗ \n" +
                                  "   ██╔════╝██╔══██╗██║     ██╔════╝██║   ██║██║     ██╔══██╗╚══██╔══╝██╔═══██╗██╔══██╗\n" +
                                  "   ██║     ███████║██║     ██║     ██║   ██║██║     ███████║   ██║   ██║   ██║██████╔╝\n" +
                                  "   ██║     ██╔══██║██║     ██║     ██║   ██║██║     ██╔══██║   ██║   ██║   ██║██╔══██╗\n" +
                                  "   ╚██████╗██║  ██║███████╗╚██████╗╚██████╔╝███████╗██║  ██║   ██║   ╚██████╔╝██║  ██║\n" +
                                  "    ╚═════╝╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝\n" +
                                  "                                                                                      \n");
                Console.WriteLine("  Selecione um tipo de operação\n \n" +
                                  "  soma\n" +
                                  "  multiplicação\n" +
                                  "  subtração\n" +
                                  "  divisão\n" +
                                  "  sair\n");
                entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "soma"://Efetua soma
                        CalcMain.Soma();
                        break;
                    case "subtração":
                        CalcMain.Subtracao();
                        break;
                    case "divisão":
                        CalcMain.Divisao();
                        break;
                    case "multiplicação":
                        CalcMain.Multiply();
                        break;
                    case "sair":

                        break;
                    default:
                        Console.WriteLine("Digite uma opção valida!");
                        break;
                }
            } while (entrada != "sair");
        }

        static void Main(string[] args)
        {
            MenuInterface();
        }
    }
}
