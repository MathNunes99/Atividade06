using System;

//Desenvolver um algoritmo que leia 5 valores inteiros e calcule e escreva a 
//média aritmética dos valores lidos, a quantidade de valores positivos e a 
//quantidade de valores negativos.


namespace Exercicio04
{
    internal class Exercicio04
    {
        static void Main(string[] args)
        {
            string[] valores = new string[5];
            double media = 0;
            int negativos = 0;
            int positivos = 0;
            Console.WriteLine("Escreva 5 numeros inteiros!");
            Console.WriteLine("Como resultado sairá, a média aritmética entre eles e quantos sao positivos e negativos!");
            
            for(int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Escreva o "+ (i+1) + " numero");
                valores[i] = Console.ReadLine();
                media = media + Convert.ToInt32(valores[i]);
                if(Convert.ToInt32(valores[i]) >= 0)
                {
                    positivos = positivos+1;
                }
                else if (Convert.ToInt32(valores[i]) < 0)
                {
                    negativos = negativos+1;
                }
            }
            media = media / 5;
            Console.WriteLine("A média foi: " + media);
            Console.WriteLine("numeros positivos: " + positivos);
            Console.WriteLine("numeros negativos: " + negativos);
            Console.ReadLine();
        }
    }
}
