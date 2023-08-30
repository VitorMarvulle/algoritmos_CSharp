using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, r_soma, r_sub, r_mult, r_div;
            Console.Write("Digite o Número 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o Número 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            
            r_soma = n1+n2;
            r_sub = n1-n2;
            r_mult = n1*n2;
            r_div = n1/n2;

            Console.WriteLine("A soma é: " +r_soma);
            Console.WriteLine("A subtração é: " +r_sub);
            Console.WriteLine("A multiplicação é: " +r_mult);
            Console.WriteLine("A divisão é: " +r_div);
        }
    }
}