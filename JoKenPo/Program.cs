namespace JoKenPo
{
    class Program
    {

        public static void Main(string[] args)
        {
            System.Console.WriteLine("----- JoKenPo -----");

            System.Console.WriteLine();

            System.Console.WriteLine("[ 1 ] Pedra\n[ 2 ] Papel\n[ 3 ] Tesoura\n");

            System.Console.Write(">>>>> Sua opção: ");
            int jogador = int.Parse(Console.ReadLine());

            System.Console.WriteLine();

            if (jogador < 1 || jogador > 3)
            {
                System.Console.WriteLine("Opção inválida.");

                Console.ReadLine();

                return;
            }

            Random random = new Random();

            int computador = random.Next(1, 4);

            if (jogador == 1)
            {
                System.Console.WriteLine("Jogador jogou Pedra");

                if (computador == 1)
                {
                    System.Console.WriteLine("Computador jogou Pedra");
                    System.Console.WriteLine();
                    System.Console.WriteLine("EMPATE!");
                }
                else if (computador == 2)
                {
                    System.Console.WriteLine("Computador jogou Papel");
                    System.Console.WriteLine();
                    System.Console.WriteLine("COMPUTADOR VENCE!");
                    
                }
                else if (computador == 3)
                {
                    System.Console.WriteLine("Computador jogou Tesoura");
                    System.Console.WriteLine();
                    System.Console.WriteLine("JOGADOR VENCE!");
                }
            }
            else if (jogador == 2)
            {
                System.Console.WriteLine("Jogador jogou Papel");
                
                if (computador == 1)
                {
                    System.Console.WriteLine("Computador jogou Pedra");
                    System.Console.WriteLine();
                    System.Console.WriteLine("JOGADOR VENCE!");

                }
                else if (computador == 2)
                {
                    System.Console.WriteLine("Computador jogou Papel");
                    System.Console.WriteLine();
                    System.Console.WriteLine("EMPATE!");
                }
                else if (computador == 3)
                {
                    System.Console.WriteLine("Computador jogou Tesoura");
                    System.Console.WriteLine();
                    System.Console.WriteLine("COMPUTADOR VENCE!");
                }
            }
            else if (jogador == 3)
            {
                System.Console.WriteLine("Jogador jogou Tesoura");

                if (computador == 1)
                {
                    System.Console.WriteLine("Computador jogou Pedra");
                    System.Console.WriteLine();
                    System.Console.WriteLine("COMPUTADOR VENCE!");
                }
                else if (computador == 2)
                {
                    System.Console.WriteLine("Computador jogou Papel");
                    System.Console.WriteLine();
                    System.Console.WriteLine("JOGADOR VENCE!");
                }
                else if (computador == 3)
                {
                    System.Console.WriteLine("Computador jogou Tesoura");
                    System.Console.WriteLine();
                    System.Console.WriteLine("EMPATE!");
                }
            }
        
            Console.ReadLine();
        }
    }     
}