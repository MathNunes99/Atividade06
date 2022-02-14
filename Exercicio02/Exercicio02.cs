using System;

//Desenhe um retângulo com asteriscos, onde as forem linhas pares escreva 
//"A" e as linhas ímpares escreva "B"

namespace Exercicio02
{
    internal class Exercicio02
    {
        static void Main(string[] args)
        {
            string[] caracteres = new string[2];
            
            string strlargura = "";
            Console.WriteLine("ESCREVA A LARGURA DO RETANGULO");
            int largura = int.Parse(Console.ReadLine());
            Console.WriteLine("ESCREVA A ALTURA DO RETANGULO");
            int altura = int.Parse(Console.ReadLine());

            for (int i = 0; i < largura; i++)
            {   
                strlargura = strlargura + "*";
                if(i%2 == 0)
                {
                    caracteres[0] = caracteres[0]+"A";
                }
                else
                {
                    caracteres[1] = caracteres[1] + "B";
                }
            }

            for (int i = 0; i < altura; i++)
            {
                Console.WriteLine(strlargura);
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("PRESSIONE ENTER PARA MOSTRAR OS CARACTERES");
            Console.WriteLine("--------------------");
            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < altura; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(caracteres[0]);
                }
                else
                {
                    Console.WriteLine(caracteres[1]);
                }
            }
            Console.ReadLine();

        }
    }
}
