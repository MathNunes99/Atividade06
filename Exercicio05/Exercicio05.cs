using System;

//Criar um jogo simplificado onde dois jogadores podem jogar dados;
//Regras:
//• O jogo deverá solicitar o nome dos dois jogadores;
//O jogo terá 3 rodadas;
//O jogador que tirar o maior número nos dados nessas 3 rodadas vence;
//• Em caso de empate (onde os dois tiram o mesmo número), nenhum
//jogador pontuará;
//• Os números permitidos vão de 0 a 6

namespace Exercicio05
{
    internal class Exercicio05
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[2];
            Console.WriteLine("JOGO PARA DOIS JOGADORES");
            Console.WriteLine("DIGITE OS NOMES DOS JOGADORES: ");
            Console.WriteLine("DIGITE O NOME DO PRIMEIRO JOGADOR");
            nomes[0] = Console.ReadLine();
            Console.WriteLine("DIGITE O NOME DO SEGUNDO JOGADOR");
            nomes[1] = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("APERTE ENTER PARA VER O RESULTADO DOS DADOS !!!");
            Console.ReadLine();
            Console.Clear();

            int dado1 = 0;
            int dado2 = 0;
            int jogador1 = 0;
            int jogador2 = 0;
            Random numAleatorio = new Random();
            for (int i = 0; i < 3; i++)
            {

                dado1 = numAleatorio.Next(1, 7);
                Console.WriteLine(nomes[0] + " Tirou " + dado1);
                dado2 = numAleatorio.Next(1, 7);
                Console.WriteLine(nomes[1] + " Tirou " + dado2);

                if (dado1 > dado2)
                {
                    Console.WriteLine(nomes[0] + " Venceu a " + (i + 1) + "a rodada");
                    jogador1++;
                    Console.WriteLine("--------------------------------");
                }
                else if(dado2 > dado1)
                {
                    Console.WriteLine(nomes[1] + " Venceu a " + (i + 1) + "a rodada");
                    jogador2++;
                    Console.WriteLine("--------------------------------");
                }
                else if(dado1 == dado2)
                {
                    Console.WriteLine("EMPATE !!!");
                    Console.WriteLine("--------------------------------");
                }
            }

            Console.WriteLine("APERTE ENTER PARA VER OS RESULTADOS!");
            Console.ReadLine();

            if (jogador1 == jogador2)
            {
                Console.WriteLine("HOUVE UM EMPATE DEFINITIVO !!!");
            }
            else if (jogador1 > jogador2)
            {
                Console.WriteLine(nomes[0]+ " VENCEU A PARTIDA!");
            }
            else if (jogador2 > jogador1)
            {
                Console.WriteLine(nomes[1] + " VENCEU A PARTIDA!");
            }
            Console.ReadLine();
        }
    }
}
