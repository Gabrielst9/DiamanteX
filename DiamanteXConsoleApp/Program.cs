namespace DiamanteXConsoleApp
{
    internal class Program
    {
        //Dado um número ímpar, exiba um diamante desenhado com a letra ‘x’.
        //No diamante acima, o número é 21, pois há 21 colunas e 21 ‘x’ na linha central.
        static void Main(string[] args)
        {
            while (true)
            {
                ExibirCabecalho();

                int numeroImpar = ObterInteiro("| " + "Digite um número ímpar:" + "|");

                if (numeroImpar % 2 == 0)
                {
                    Console.WriteLine("Número inválido! Digite um número ímpar.");
                }
                else
                {
                    DesenhandoDiamante(numeroImpar);
                }

                DesejaContinuar("| " + "Deseja Continuar? (S/N)" + " |");
            }
        }


        #region ExibirCabecalho
        private static void ExibirCabecalho()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("| " + "DIAMANTES DE X" + " |");
            Console.WriteLine("------------------");
        }
        #endregion


        #region ObterInteiro
        static int ObterInteiro(string texto)
        {

            Console.WriteLine("\n--------------------------");
            Console.WriteLine(texto);
            Console.WriteLine("--------------------------");

            int numeroDigitado = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            return numeroDigitado;
        }
        #endregion

        #region Desenhando o Diamante
        private static void DesenhandoDiamante(int numeroImpar)
        {
            //Desenhando a parte de cima do diamante
            for (int i = 1; i <= numeroImpar; i += 2)
            {
                //Fazendo o espaçamento
                for (int j = 0; j < (numeroImpar - i) / 2; j++)
                {
                    Console.Write(" ");
                }
                //Desenhando os "x"
                for (int j = 0; j < i; j++)
                {
                    Console.Write("x");
                }
                //Falando pra ir para a parte de baixo
                Console.WriteLine();
            }

            //Desenhando a parte de baixo do diamante
            for (int i = numeroImpar - 2; i > 0; i -= 2)
            {
                //Fazendo o espaçamento
                for (int j = 0; j < (numeroImpar - i) / 2; j++)
                {
                    Console.Write(" ");
                }
                //Desenhando os "x"
                for (int j = 0; j < i; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------");
        }
        #endregion

        #region Deseja Continuar
        static void DesejaContinuar(string texto)
        {

            Console.WriteLine("\n---------------------------");
            Console.WriteLine(texto);
            Console.WriteLine("---------------------------");

            string verifica = Console.ReadLine().ToUpper();

            while (verifica != "S" && verifica != "N")
            {
                Console.WriteLine("\n Opção inválida. Digite S para continuar ou N para sair.");
                verifica = Console.ReadLine().ToUpper();
            }

            if (verifica == "N")
            {
                Environment.Exit(0);
            }
        }
        #endregion


    }
}
