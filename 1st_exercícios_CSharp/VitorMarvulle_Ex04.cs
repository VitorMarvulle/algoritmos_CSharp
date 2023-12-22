using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;
            Console.Write("Digite a Nota 1: ");
            n1= Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a Nota 2: ");
            n2= Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a Nota 3: ");
            n3= Convert.ToDouble(Console.ReadLine());

            media=(n1+n2+n3)/3;

            Console.WriteLine("Sua média final é: " +media);
        }


    }
}