using System;

//Desenhe um retângulo com asteriscos, considere que o primeiro input é a
//largura do retângulo, e o segundo input é a altura.

namespace Atividade06.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strlargura = "";
            Console.WriteLine("ESCREVA A LARGURA DO RETANGULO");
            int largura = int.Parse(Console.ReadLine());
            Console.WriteLine("ESCREVA A ALTURA DO RETANGULO");
            int altura = int.Parse(Console.ReadLine());

            for(int i = 0; i < largura; i++)
            {
                strlargura = strlargura + "*";
            }

            for(int i = 0;i < altura; i++)
            {
                Console.WriteLine(strlargura);
            }            
            Console.ReadLine();
            
        }
    }
}
