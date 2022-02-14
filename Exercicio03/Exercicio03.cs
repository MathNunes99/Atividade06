using System;

namespace Exercicio03
{
    internal class Exercicio03
    {
        static void Main(string[] args)
        {

            int horaAtual = 0;
            Console.WriteLine("Que horas são?");
            Console.WriteLine("escreva somente numeros inteiros");
            horaAtual = int.Parse(Console.ReadLine());

            if(horaAtual >= 5 && horaAtual <= 12)
            {
                Console.WriteLine("BOM DIA!");
            }
            else if(horaAtual > 12 && horaAtual <= 19)
            {
                Console.WriteLine("BOA TARDE!");
            }
            else if(horaAtual > 19)
            {
                Console.WriteLine("BOA NOITE!");
            }
            Console.ReadLine();
        }
    }
}
